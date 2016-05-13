using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Pcis.common;
using System.Configuration;
using System.Threading.Tasks;
using SipleLogger;
using DriveInfo = System.IO.DriveInfo;
using File = System.IO.File;
using FileInfo = System.IO.FileInfo;
using System.Text.RegularExpressions;


namespace IndexServiceLibrary
{
    public class EventStatusBool : EventArgs
    {
        public bool eventStatusBool { get; set; }
    }

    public class IndexService : IIndexService, IFileService
    {
        public delegate void EventIndexStatusHandler(IndexService iService, EventStatusBool e);
        public event EventIndexStatusHandler UpdateStatusEvent; 


        private static List<IndexFile> indexFiles = new List<IndexFile>();
        private static  List<string> tokenList = new List<string>();
        private static bool Status { get; set; } = false; 
        private static string _indexFileName = "UniIndex.idx";
        private static bool _netdrive = false;
        private static string _indexfilepath = AppDomain.CurrentDomain.BaseDirectory + "\\indexfiles\\";
        private static int _tokengennum = 20; 
        private static string[] Drives { get; set; } = new[] {"all"};
        private static bool usemd5  = false;
        private static string[] Filter { get; set; } = null;
        private static bool _logindexing = false;
        private static bool _settingsSet = false;
        private static SimpleLogger _logger = new SimpleLogger();  
       
        private List<IndexFile> _searchResult = new List<IndexFile>(); 
        private string ip;
        private string name; 

        public IndexService()
        {
            //TODO Evaluate reading settings on every connect not needing static
            if (!_settingsSet) ReadSettings();

           // if (indexFiles.Count < 1)
           // {
           //     CreateIndex(); 
           // }

            //Get client IP and name 
            OperationContext context = OperationContext.Current;
            if (context != null)
            {
                MessageProperties prop = context.IncomingMessageProperties;
                RemoteEndpointMessageProperty endpoint =
                    prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                ip = endpoint.Address;
                _logger.Add("Connecting ip: " + ip);
                
                name = OperationContext.Current.ServiceSecurityContext.PrimaryIdentity.Name;
                _logger.Write("Connecting name: " + name);
            }
        }
        
        public bool ReadSettings()
        {
            //TODO can we have all settings in a dictionery key / value as strings 
           
            var key = ConfigurationManager.AppSettings["Drives"].Replace(" ", string.Empty);
            _logger.Add("Drives set to: " + key);
            if (key != "all")
            {
                Drives = key.Split(',');
            }
            Boolean.TryParse(ConfigurationManager.AppSettings["netdrives"], out _netdrive);
            _logger.Add("netdrive set to: " + _netdrive);

            _indexFileName = ConfigurationManager.AppSettings["indexfilename"];
            _logger.Add("indexfilename set t : " + _indexFileName);

            var path  = ConfigurationManager.AppSettings["indexfilepath"];
            if (path != "approot")
            {
                _indexfilepath = path;
            }
            else
            {
                _indexfilepath = AppDomain.CurrentDomain.BaseDirectory + "\\indexfiles\\"; 
            }
            _logger.Add("indexfilePath set to: " + _indexfilepath);
            int.TryParse(ConfigurationManager.AppSettings["tokengennum"], out _tokengennum);

            Boolean.TryParse(ConfigurationManager.AppSettings["usemd5"], out usemd5);
            _logger.Add("usemd5 set to: " + usemd5);

            key = ConfigurationManager.AppSettings["filter"].Replace(" ", string.Empty);
            _logger.Add("Filter set to: " + key);
            if (!string.IsNullOrEmpty(key))
            {
                Filter = key.Split(',');
                Filter = WildCardRegexify(Filter);
            }
            Boolean.TryParse(ConfigurationManager.AppSettings["logindexing"], out _logindexing);
            _logger.Add("logging indexing set to: " + _logindexing);

            _settingsSet = true;
            return true; 
        }


        #region  IindexService methods

        public bool AddUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password)) return false;
            _logger.Add("Add/update user   " + name);
            return AppConfigWriter.Write(name, SHA256Hash.GetHashString(password));
        }
        public bool ChangePassword(string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword)) return false;
            var userName = OperationContext.Current.ServiceSecurityContext.PrimaryIdentity.Name;
            if (!AppConfigWriter.Write(userName, SHA256Hash.GetHashString(newPassword))) return false;
            _logger.Add("Changed password for user: " + userName);
            return true;
        }

        public bool ClearIndex()
        {
            indexFiles = new List<IndexFile>();
            FileHandler fileHandler = new FileHandler();
            fileHandler.DeleteIndexFiles(_indexfilepath);
            _logger.Add("Index cleared");
            return true;
        }
        public bool ClearLog()
        {
            _logger.Dump();
            return true;
        }

        public bool CreateIndex()
        {
            Task.Factory.StartNew(GetIndex);
            return true;
        }

        public int FolderCount()
        {
            return indexFiles.Select(x => x.Folder).Distinct().Count();
        }

        public bool GetIndexStatus()
        {
            return Status;
        }

        public List<string> GetLog()
        {
            return _logger.GetLog();
        }

        public SimpleLogger GetLogger()
        {
            return _logger;
        }

        public string GetToken()
        {
            string token = SHA256Hash.GetHashString(ip + name + DateTime.Now + RandomStringGenerator.NextString(_tokengennum));
            tokenList.Add(token);
            _logger.Add("Generated Token for client");
            return token;
        }

        public int IndexSize()
        {
            return indexFiles.Count;
        }

        public bool StartIndex(string[] drives)
        {
            if (drives[0].ToLower() == "all")
            {
                drives = Environment.GetLogicalDrives();
            }
            DateTime starttime = DateTime.Now;
            _logger.Add("Start building index.");
            Task[] task = new Task[drives.Length];
            int numtask = 0;
            foreach (var drive in drives)
            {
                var t = Task.Factory.StartNew(() => ScanDrives(drive), TaskCreationOptions.LongRunning);
                task[numtask] = t;
                numtask++;
            }
            Task.WaitAll(task);

            _logger.Add("Index Created in: " + (DateTime.Now - starttime).TotalMilliseconds);
            _logger.Add($"Files: {indexFiles.Count} Folders: {FolderCount()} ");
            Serializer ser = new Serializer();
            ser.SaveData(indexFiles, _indexFileName, _indexfilepath);
            return true;
        }

        public List<IndexFile> Search(string text, string ext)
        {
            _logger.Add("Search string = " + text + " " + ext);
            _searchResult = SearchFile(text, ext);
            return _searchResult;
        }
        #endregion
        
        private void SetStatus(bool indexStatus)
        {
            Status = indexStatus;
            if (UpdateStatusEvent != null)
            {
                EventStatusBool statusUpdate = new EventStatusBool();
                statusUpdate.eventStatusBool = indexStatus;
                UpdateStatusEvent(this, statusUpdate);
            }
        }

#region Private functions
        private void GetIndex()
        {
           
            if (indexFiles.Count < 1)
            {
                _logger.Add("No files in index");
                if (!Diserialization(_indexFileName))
                {
                    if (StartIndex(Drives))
                    {
                        _logger.Add("Index is ready ");
                        SetStatus(true);
                    }
                }
                else
                {
                    _logger.Add("Index is ready ");
                    SetStatus(true);
                }
            }
            else
            {
                _logger.Add("No Need ceate index");
            }
            
        }
        private bool Diserialization(string filename)
        {
            Serializer ser = new Serializer();
            var list = ser.LoadData(_indexFileName, _indexfilepath);
            if (list != null && list.Count > 0)
            {
                indexFiles = list;
                return true;
            }
            _logger.Add("No Binery files");
            return false;
        }

        private void ScanDrives(string drive)
        {
            DateTime startTime = DateTime.Now;
            DriveInfo di = new DriveInfo(drive);

            if (di.DriveType == DriveType.Fixed || di.DriveType == DriveType.Network && _netdrive == true)
            {
                if (di.IsReady)
                {
                    _logger.Add($"Indexing drive: {drive}");
                    System.Native.IO.FileSystem.DirectoryInfo rootDirectoryInfo =
                        new System.Native.IO.FileSystem.DirectoryInfo(di.RootDirectory.FullName);
                    DirectoryTreeWalker(rootDirectoryInfo);
                    _logger.Add($"Index for drive: {drive} Created in {(DateTime.Now - startTime).TotalMilliseconds}");
                }
                else
                {
                    _logger.Add($"Drive: {drive} was not ready");
                }
            }
            else
            {
                _logger.Add($"Drive {di.Name} skipped driveType: {di.DriveType}");
            }
        }

        private string[] WildCardRegexify(string[] filters)
        {
            int num = filters.Count();
            for (int i = 0; num > i; i++)
            {
                filters[i] = "^" + Regex.Escape(filters[i]).Replace(@"\*", ".*").Replace(@"\?", ".") + "$";

            }
            return filters;
        }
         
        private bool FilterValidate(string str, string[] filters)
        {
            bool ret = false;
            str = str.ToUpper();
            foreach (var filter in filters)
            {
                ret = new Regex( filter,RegexOptions.IgnoreCase | RegexOptions.Singleline).IsMatch(str);
                if (ret)
                {
                    if (_logindexing)
                    {
                        _logger.Add("String : " + str + " filter :" + filter);
                    }
                    return ret;
                }
            }
            return ret;
        }


        private void DirectoryTreeWalker(System.Native.IO.FileSystem.DirectoryInfo rootDirectoryInfo)
        {
            System.Native.IO.FileSystem.FileInfo[] files = null;

            if (!Filter.Contains(rootDirectoryInfo.Name.ToUpper()))
            {
                if(!FilterValidate(rootDirectoryInfo.Name, Filter))
                try
                {
                    files = rootDirectoryInfo.GetFiles();
                }
                catch (UnauthorizedAccessException e)
                {
                    _logger.Add(e.Message);
                }
                catch (DirectoryNotFoundException e)
                {
                    _logger.Add(e.Message);
                }
                catch (Exception e)
                {
                    _logger.Add(e.Message);
                }
                if (files != null)
                {
                    foreach (var fileInfo in files)
                    {
                        //TODO file regex from here 
                        IndexFile indexfile = new IndexFile
                        {
                            Name = fileInfo.Name,
                            Folder = fileInfo.DirectoryName,
                            Extension = fileInfo.Extension
                        };

                        if (usemd5)
                        {
                            try
                            {
                                //TODO validate file hash method for speed and less colision 
                                FileHandler fi = new FileHandler();
                                //fi.MD5Checsum(fileInfo.OpenRead(), fileInfo.Length);
                                fi.Sha1Hash(fileInfo.OpenRead() , fileInfo.Length);

                            }
                            catch (Exception)
                            {
                                
                                // ignore 
                            }
                        }
                        indexFiles.Add(indexfile);
                    }
                    var subDir = rootDirectoryInfo.GetDirectories();
                    foreach (var directoryInfo in subDir)
                    {
                        DirectoryTreeWalker(directoryInfo);
                    }
                }
            }
        }

        

        private List<IndexFile> SearchFile(string text = null, string extension = null)
        {
            List<IndexFile> resultList = new List<IndexFile>();

            // NOTE Using toUpper can be unwanted where language upper and lower case have different meaning 
            // impact of this should be low as result would be finding some extra files 

            //TODO add regex wildcard search and case sensetivity

            if (!String.IsNullOrEmpty(extension) && !String.IsNullOrEmpty(text))
            {
                resultList = indexFiles.FindAll(X => X.Name.ToUpper().Contains(text.ToUpper()) && X.Extension.ToUpper().Contains(extension.ToUpper()));
            }
            else if (!String.IsNullOrEmpty(text))
            {
                resultList = indexFiles.FindAll(X => X.Name.ToUpper().Contains(text.ToUpper()));
            }
            else if (!string.IsNullOrEmpty(extension))
            {
                resultList = indexFiles.FindAll(X => X.Extension.ToUpper().Contains(extension.ToUpper()));
            }

            return resultList;
        }
#endregion

        #region IFileService
        public Stream DownloadFileStream(string fileName, string token)
        {
            if (tokenList.Contains(token))
            {
                string file = fileName;
                try
                {
                    if (File.Exists(fileName))
                    {
                        FileStream upFile = File.OpenRead(file);
                        _logger.Add("Removing Token: " + token);
                        tokenList.Remove(token);
                        return upFile;
                    }
                    _logger.Add(fileName + " Don't exist");
                    throw new FileNotFoundException("File don't exist", fileName);
                }
                catch (IOException ex)
                {
                    _logger.Add(ex.Message);
                    throw;
                }
            }
            _logger.Add("No valid Token.");
            throw new AccessViolationException("No Valid token");
        }


        public long GetFileSize(string fileName, string token)
        {
            if (tokenList.Contains(token))
            {
                string file = fileName;
                if (File.Exists(fileName))
                {
                    FileInfo fInfo = new FileInfo(file);
                    return fInfo.Length;
                }
                _logger.Add(fileName + " Don't exist");
                throw new FileNotFoundException("File don't exist", fileName);
            }
            _logger.Add("No valid Token.");
            throw new AccessViolationException("No Valid token");
        }

        public FileInfo GetFileInfo(string file)
        {
            _logger.Add(file);
            return new FileInfo(file);
        }
        #endregion
        
    }
}
