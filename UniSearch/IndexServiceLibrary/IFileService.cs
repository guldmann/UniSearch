using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IndexServiceLibrary
{
    [ServiceContract]
    interface IFileService
    {
        [OperationContract]
        Stream DownloadFileStream(string fileName, string token);

        [OperationContract]
        long GetFileSize(string fileNAme, string token); 
    }
    
}
