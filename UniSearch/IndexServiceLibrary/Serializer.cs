using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Pcis.common;
using IFormatter = System.Runtime.Serialization.IFormatter;
using SipleLogger;

namespace IndexServiceLibrary
{
    class Serializer
    {        
        private const int NumOfDataObjectsPerSerializedPage = 400000;
        private SimpleLogger logger = new SimpleLogger();

        public Serializer()
        {
           
        }
      

        public List<IndexFile> LoadData(string fileName, string indexfilepath)
        {
            string file;
            List<IndexFile> indexfiles = new List<IndexFile>(); 
            if (Directory.Exists(indexfilepath))
            {
                int fileCount = Directory.GetFiles(indexfilepath, "*", SearchOption.TopDirectoryOnly).Length;
                if (fileCount < 1) return null;
                for (int i = 0; i < fileCount; i++)
                {

                    file = indexfilepath + fileName + i;
                    if (File.Exists(file))
                    {
                        logger.Add($"Reading index from file: {file}......");
                        var startTime = DateTime.Now; 
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                        indexfiles.AddRange((List<IndexFile>)formatter.Deserialize(stream));
                        stream.Close();
                        logger.Add($"Files in index: {indexfiles.Count} in {(DateTime.Now-startTime).TotalMilliseconds}" );
                    }
                }

                indexfiles.RemoveAll(item => item == null);
                return indexfiles;
            }
            logger.Add("No indexFiles found on disk.");
            return null;
        }
        /// <summary>
        /// Split in memory index to pages to write to disk
        /// </summary>
        /// <param name="indexfiles">The indexfiles.</param>
        /// <param name="filenName">Name for the index files</param>
        public void SaveData(List<IndexFile> indexfiles, string filenName, string folder)
        {
            if (indexfiles.Count > 1 && !string.IsNullOrEmpty(filenName))
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                else
                {
                    FileHandler fileHandler = new FileHandler();
                    fileHandler.DeleteIndexFiles(folder);
                }

                int numOfADataFields = indexfiles == null ? 0 :
              (int)Math.Ceiling(indexfiles.Count / (Double)NumOfDataObjectsPerSerializedPage);

                for (int i = 0; i < numOfADataFields; i++)
                {
                    List<IndexFile> page = indexfiles.Skip(NumOfDataObjectsPerSerializedPage * i).Take(NumOfDataObjectsPerSerializedPage).ToList();
                    WritePage(page, filenName + i, folder);
                }
            }
        }

        /// <summary>
        /// Writes the index page to disk. 
        /// </summary>
        /// <param name="indexfiles">The indexfiles.</param>
        /// <param name="filenName">Name of the out files.</param>
        /// <param name="folder">Folder to save files </param>
        private void WritePage(List<IndexFile> indexfiles, string filenName, string folder)
        {
           
            logger.Add($"Writing index to file: {filenName}..... ");
            string file = folder + filenName;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, indexfiles);
            stream.Close();
        }

        //TODO refactor this common used in indexservice clear index
        private void DeleteOldIndexFiles(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (var fileInfo in di.GetFiles())
                {
                    fileInfo.Delete();
                    logger.Add("Index file: " + fileInfo.Name + " Deleted.");
                }
            }
        }
    }
}
