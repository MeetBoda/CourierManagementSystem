﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/CourierManagementSystem")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;
        
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
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/register", ReplyAction="http://tempuri.org/IUserService/registerResponse")]
        string register(string user_name, string email, string password, string mobile_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/register", ReplyAction="http://tempuri.org/IUserService/registerResponse")]
        System.Threading.Tasks.Task<string> registerAsync(string user_name, string email, string password, string mobile_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        Client.UserServiceReference.UserInfo login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        System.Threading.Tasks.Task<Client.UserServiceReference.UserInfo> loginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : Client.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Client.UserServiceReference.IUserService>, Client.UserServiceReference.IUserService {
        
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
        
        public string register(string user_name, string email, string password, string mobile_no) {
            return base.Channel.register(user_name, email, password, mobile_no);
        }
        
        public System.Threading.Tasks.Task<string> registerAsync(string user_name, string email, string password, string mobile_no) {
            return base.Channel.registerAsync(user_name, email, password, mobile_no);
        }
        
        public Client.UserServiceReference.UserInfo login(string email, string password) {
            return base.Channel.login(email, password);
        }
        
        public System.Threading.Tasks.Task<Client.UserServiceReference.UserInfo> loginAsync(string email, string password) {
            return base.Channel.loginAsync(email, password);
        }
    }
}
