using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SipleLogger;

namespace IndexServiceLibrary
{
    public  class FileHandler
    {
        SimpleLogger logger = new SimpleLogger();

        public  bool DeleteIndexFiles(string path)
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
            return true;
        }



        public string Sha1Hash(FileStream dirFile, long length)
        {
            try
            {
                
                var startTime = DateTime.Now;
                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                string ret = BitConverter.ToString(sha.ComputeHash(dirFile)).Replace("-", "").ToLower();
                dirFile.Close();
                //logger.Write("sha " + dirFile.Name + " in: "+(DateTime.Now - startTime).TotalMilliseconds.ToString() + " Size: " + length+ " hasch: " + ret);
                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string MD5Checsum(FileStream dirFile, long length)
        {
            try
            {
                var startTime = DateTime.Now;
                var md5Sum = MD5.Create();
                string ret = BitConverter.ToString(md5Sum.ComputeHash(dirFile)).Replace("-", "").ToLower();
                dirFile.Close();
              // logger.Write("sha " + dirFile.Name + " in: " + (DateTime.Now - startTime).TotalMilliseconds.ToString() + " size: " + length + " hasch: " + ret);
                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
