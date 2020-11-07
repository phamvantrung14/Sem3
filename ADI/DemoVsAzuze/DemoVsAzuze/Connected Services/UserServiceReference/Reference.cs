﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoVsAzuze.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WebServiceAssigment2.Models.DataModels")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserList", ReplyAction="http://tempuri.org/IUserService/GetUserListResponse")]
        DemoVsAzuze.UserServiceReference.User[] GetUserList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserList", ReplyAction="http://tempuri.org/IUserService/GetUserListResponse")]
        System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User[]> GetUserListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUser", ReplyAction="http://tempuri.org/IUserService/AddUserResponse")]
        void AddUser(DemoVsAzuze.UserServiceReference.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUser", ReplyAction="http://tempuri.org/IUserService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(DemoVsAzuze.UserServiceReference.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserById", ReplyAction="http://tempuri.org/IUserService/GetUserByIdResponse")]
        DemoVsAzuze.UserServiceReference.User GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserById", ReplyAction="http://tempuri.org/IUserService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        void UpdateUser(DemoVsAzuze.UserServiceReference.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(DemoVsAzuze.UserServiceReference.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserCheck", ReplyAction="http://tempuri.org/IUserService/GetUserCheckResponse")]
        DemoVsAzuze.UserServiceReference.User GetUserCheck(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserCheck", ReplyAction="http://tempuri.org/IUserService/GetUserCheckResponse")]
        System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User> GetUserCheckAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        void DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : DemoVsAzuze.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<DemoVsAzuze.UserServiceReference.IUserService>, DemoVsAzuze.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DemoVsAzuze.UserServiceReference.User[] GetUserList() {
            return base.Channel.GetUserList();
        }
        
        public System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User[]> GetUserListAsync() {
            return base.Channel.GetUserListAsync();
        }
        
        public void AddUser(DemoVsAzuze.UserServiceReference.User u) {
            base.Channel.AddUser(u);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(DemoVsAzuze.UserServiceReference.User u) {
            return base.Channel.AddUserAsync(u);
        }
        
        public DemoVsAzuze.UserServiceReference.User GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public void UpdateUser(DemoVsAzuze.UserServiceReference.User u) {
            base.Channel.UpdateUser(u);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(DemoVsAzuze.UserServiceReference.User u) {
            return base.Channel.UpdateUserAsync(u);
        }
        
        public DemoVsAzuze.UserServiceReference.User GetUserCheck(string email) {
            return base.Channel.GetUserCheck(email);
        }
        
        public System.Threading.Tasks.Task<DemoVsAzuze.UserServiceReference.User> GetUserCheckAsync(string email) {
            return base.Channel.GetUserCheckAsync(email);
        }
        
        public void DeleteUser(int id) {
            base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
    }
}
