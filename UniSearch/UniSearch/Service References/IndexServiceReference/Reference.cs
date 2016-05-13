﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniSearch.IndexServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IndexFile", Namespace="http://schemas.datacontract.org/2004/07/Pcis.common")]
    [System.SerializableAttribute()]
    public partial class IndexFile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Extensionk__BackingFieldField;
        
        private string Folderk__BackingFieldField;
        
        private string MD5k__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        private string typek__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Extension>k__BackingField", IsRequired=true)]
        public string Extensionk__BackingField {
            get {
                return this.Extensionk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Extensionk__BackingFieldField, value) != true)) {
                    this.Extensionk__BackingFieldField = value;
                    this.RaisePropertyChanged("Extensionk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Folder>k__BackingField", IsRequired=true)]
        public string Folderk__BackingField {
            get {
                return this.Folderk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Folderk__BackingFieldField, value) != true)) {
                    this.Folderk__BackingFieldField = value;
                    this.RaisePropertyChanged("Folderk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MD5>k__BackingField", IsRequired=true)]
        public string MD5k__BackingField {
            get {
                return this.MD5k__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.MD5k__BackingFieldField, value) != true)) {
                    this.MD5k__BackingFieldField = value;
                    this.RaisePropertyChanged("MD5k__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField {
            get {
                return this.Namek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Namek__BackingFieldField, value) != true)) {
                    this.Namek__BackingFieldField = value;
                    this.RaisePropertyChanged("Namek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<type>k__BackingField", IsRequired=true)]
        public string typek__BackingField {
            get {
                return this.typek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.typek__BackingFieldField, value) != true)) {
                    this.typek__BackingFieldField = value;
                    this.RaisePropertyChanged("typek__BackingField");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IndexServiceReference.IIndexService")]
    public interface IIndexService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ChangePassword", ReplyAction="http://tempuri.org/IIndexService/ChangePasswordResponse")]
        bool ChangePassword(string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ChangePassword", ReplyAction="http://tempuri.org/IIndexService/ChangePasswordResponse")]
        System.Threading.Tasks.Task<bool> ChangePasswordAsync(string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/AddUser", ReplyAction="http://tempuri.org/IIndexService/AddUserResponse")]
        bool AddUser(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/AddUser", ReplyAction="http://tempuri.org/IIndexService/AddUserResponse")]
        System.Threading.Tasks.Task<bool> AddUserAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetToken", ReplyAction="http://tempuri.org/IIndexService/GetTokenResponse")]
        string GetToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetToken", ReplyAction="http://tempuri.org/IIndexService/GetTokenResponse")]
        System.Threading.Tasks.Task<string> GetTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetIndexStatus", ReplyAction="http://tempuri.org/IIndexService/GetIndexStatusResponse")]
        bool GetIndexStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetIndexStatus", ReplyAction="http://tempuri.org/IIndexService/GetIndexStatusResponse")]
        System.Threading.Tasks.Task<bool> GetIndexStatusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/CreateIndex", ReplyAction="http://tempuri.org/IIndexService/CreateIndexResponse")]
        bool CreateIndex();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/CreateIndex", ReplyAction="http://tempuri.org/IIndexService/CreateIndexResponse")]
        System.Threading.Tasks.Task<bool> CreateIndexAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/FolderCount", ReplyAction="http://tempuri.org/IIndexService/FolderCountResponse")]
        int FolderCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/FolderCount", ReplyAction="http://tempuri.org/IIndexService/FolderCountResponse")]
        System.Threading.Tasks.Task<int> FolderCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/IndexSize", ReplyAction="http://tempuri.org/IIndexService/IndexSizeResponse")]
        int IndexSize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/IndexSize", ReplyAction="http://tempuri.org/IIndexService/IndexSizeResponse")]
        System.Threading.Tasks.Task<int> IndexSizeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetLog", ReplyAction="http://tempuri.org/IIndexService/GetLogResponse")]
        string[] GetLog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/GetLog", ReplyAction="http://tempuri.org/IIndexService/GetLogResponse")]
        System.Threading.Tasks.Task<string[]> GetLogAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ClearLog", ReplyAction="http://tempuri.org/IIndexService/ClearLogResponse")]
        bool ClearLog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ClearLog", ReplyAction="http://tempuri.org/IIndexService/ClearLogResponse")]
        System.Threading.Tasks.Task<bool> ClearLogAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ClearIndex", ReplyAction="http://tempuri.org/IIndexService/ClearIndexResponse")]
        bool ClearIndex();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/ClearIndex", ReplyAction="http://tempuri.org/IIndexService/ClearIndexResponse")]
        System.Threading.Tasks.Task<bool> ClearIndexAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/Search", ReplyAction="http://tempuri.org/IIndexService/SearchResponse")]
        UniSearch.IndexServiceReference.IndexFile[] Search(string value, string extension);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIndexService/Search", ReplyAction="http://tempuri.org/IIndexService/SearchResponse")]
        System.Threading.Tasks.Task<UniSearch.IndexServiceReference.IndexFile[]> SearchAsync(string value, string extension);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIndexServiceChannel : UniSearch.IndexServiceReference.IIndexService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IndexServiceClient : System.ServiceModel.ClientBase<UniSearch.IndexServiceReference.IIndexService>, UniSearch.IndexServiceReference.IIndexService {
        
        public IndexServiceClient() {
        }
        
        public IndexServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IndexServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndexServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndexServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ChangePassword(string newPassword) {
            return base.Channel.ChangePassword(newPassword);
        }
        
        public System.Threading.Tasks.Task<bool> ChangePasswordAsync(string newPassword) {
            return base.Channel.ChangePasswordAsync(newPassword);
        }
        
        public bool AddUser(string name, string password) {
            return base.Channel.AddUser(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(string name, string password) {
            return base.Channel.AddUserAsync(name, password);
        }
        
        public string GetToken() {
            return base.Channel.GetToken();
        }
        
        public System.Threading.Tasks.Task<string> GetTokenAsync() {
            return base.Channel.GetTokenAsync();
        }
        
        public bool GetIndexStatus() {
            return base.Channel.GetIndexStatus();
        }
        
        public System.Threading.Tasks.Task<bool> GetIndexStatusAsync() {
            return base.Channel.GetIndexStatusAsync();
        }
        
        public bool CreateIndex() {
            return base.Channel.CreateIndex();
        }
        
        public System.Threading.Tasks.Task<bool> CreateIndexAsync() {
            return base.Channel.CreateIndexAsync();
        }
        
        public int FolderCount() {
            return base.Channel.FolderCount();
        }
        
        public System.Threading.Tasks.Task<int> FolderCountAsync() {
            return base.Channel.FolderCountAsync();
        }
        
        public int IndexSize() {
            return base.Channel.IndexSize();
        }
        
        public System.Threading.Tasks.Task<int> IndexSizeAsync() {
            return base.Channel.IndexSizeAsync();
        }
        
        public string[] GetLog() {
            return base.Channel.GetLog();
        }
        
        public System.Threading.Tasks.Task<string[]> GetLogAsync() {
            return base.Channel.GetLogAsync();
        }
        
        public bool ClearLog() {
            return base.Channel.ClearLog();
        }
        
        public System.Threading.Tasks.Task<bool> ClearLogAsync() {
            return base.Channel.ClearLogAsync();
        }
        
        public bool ClearIndex() {
            return base.Channel.ClearIndex();
        }
        
        public System.Threading.Tasks.Task<bool> ClearIndexAsync() {
            return base.Channel.ClearIndexAsync();
        }
        
        public UniSearch.IndexServiceReference.IndexFile[] Search(string value, string extension) {
            return base.Channel.Search(value, extension);
        }
        
        public System.Threading.Tasks.Task<UniSearch.IndexServiceReference.IndexFile[]> SearchAsync(string value, string extension) {
            return base.Channel.SearchAsync(value, extension);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IndexServiceReference.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DownloadFileStream", ReplyAction="http://tempuri.org/IFileService/DownloadFileStreamResponse")]
        System.IO.Stream DownloadFileStream(string fileName, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DownloadFileStream", ReplyAction="http://tempuri.org/IFileService/DownloadFileStreamResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownloadFileStreamAsync(string fileName, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileSize", ReplyAction="http://tempuri.org/IFileService/GetFileSizeResponse")]
        long GetFileSize(string fileNAme, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileSize", ReplyAction="http://tempuri.org/IFileService/GetFileSizeResponse")]
        System.Threading.Tasks.Task<long> GetFileSizeAsync(string fileNAme, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : UniSearch.IndexServiceReference.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<UniSearch.IndexServiceReference.IFileService>, UniSearch.IndexServiceReference.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream DownloadFileStream(string fileName, string token) {
            return base.Channel.DownloadFileStream(fileName, token);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownloadFileStreamAsync(string fileName, string token) {
            return base.Channel.DownloadFileStreamAsync(fileName, token);
        }
        
        public long GetFileSize(string fileNAme, string token) {
            return base.Channel.GetFileSize(fileNAme, token);
        }
        
        public System.Threading.Tasks.Task<long> GetFileSizeAsync(string fileNAme, string token) {
            return base.Channel.GetFileSizeAsync(fileNAme, token);
        }
    }
}
