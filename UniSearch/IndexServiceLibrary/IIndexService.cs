using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using Pcis.common;

namespace IndexServiceLibrary
{
    [ServiceContract]
    public interface IIndexService
    {
        [OperationContract]
        bool ChangePassword(string newPassword);

        [OperationContract]
        bool AddUser(string name, string password);

        [OperationContract]
        string GetToken();

        [OperationContract]
        bool GetIndexStatus();

        [OperationContract]
        bool CreateIndex();

        [OperationContract]
        int FolderCount();

        [OperationContract]
        int IndexSize();

        [OperationContract]
        List<string> GetLog();

        [OperationContract]
        bool ClearLog();

        [OperationContract]
        bool ClearIndex();

        [OperationContract]
        FileInfo GetFileInfo(string file);

        [OperationContract]
        // TODO: this is returning IndexFile[] fix it  
        List<IndexFile> Search(string value, string extension);
    }    
}
