﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumerApi.BookServiceReference {
    using System.Runtime.Serialization;
    using System;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/RESTvsWCF")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceReference.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookList", ReplyAction="http://tempuri.org/IBookService/GetBookListResponse")]
        consumerApi.BookServiceReference.Book[] GetBookList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookList", ReplyAction="http://tempuri.org/IBookService/GetBookListResponse")]
        System.Threading.Tasks.Task<consumerApi.BookServiceReference.Book[]> GetBookListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        string AddBook(consumerApi.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(consumerApi.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookById", ReplyAction="http://tempuri.org/IBookService/GetBookByIdResponse")]
        consumerApi.BookServiceReference.Book GetBookById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookById", ReplyAction="http://tempuri.org/IBookService/GetBookByIdResponse")]
        System.Threading.Tasks.Task<consumerApi.BookServiceReference.Book> GetBookByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        string UpdateBook(consumerApi.BookServiceReference.Book book, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        System.Threading.Tasks.Task<string> UpdateBookAsync(consumerApi.BookServiceReference.Book book, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        string DeleteBook(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : consumerApi.BookServiceReference.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<consumerApi.BookServiceReference.IBookService>, consumerApi.BookServiceReference.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public consumerApi.BookServiceReference.Book[] GetBookList() {
            return base.Channel.GetBookList();
        }
        
        public System.Threading.Tasks.Task<consumerApi.BookServiceReference.Book[]> GetBookListAsync() {
            return base.Channel.GetBookListAsync();
        }
        
        public string AddBook(consumerApi.BookServiceReference.Book book) {
            return base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(consumerApi.BookServiceReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public consumerApi.BookServiceReference.Book GetBookById(string id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<consumerApi.BookServiceReference.Book> GetBookByIdAsync(string id) {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public string UpdateBook(consumerApi.BookServiceReference.Book book, string id) {
            return base.Channel.UpdateBook(book, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBookAsync(consumerApi.BookServiceReference.Book book, string id) {
            return base.Channel.UpdateBookAsync(book, id);
        }
        
        public string DeleteBook(string id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(string id) {
            return base.Channel.DeleteBookAsync(id);
        }

    }
}
