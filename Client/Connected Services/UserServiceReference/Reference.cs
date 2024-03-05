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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/register", ReplyAction="http://tempuri.org/IUserService/registerResponse")]
        string register(string user_name, string email, string password, string mobile_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/register", ReplyAction="http://tempuri.org/IUserService/registerResponse")]
        System.Threading.Tasks.Task<string> registerAsync(string user_name, string email, string password, string mobile_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        string login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/login", ReplyAction="http://tempuri.org/IUserService/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string email, string password);
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
        
        public string login(string email, string password) {
            return base.Channel.login(email, password);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string email, string password) {
            return base.Channel.loginAsync(email, password);
        }
    }
}