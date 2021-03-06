﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        int Sum(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        int Sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetZ", ReplyAction="*")]
        void SetZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetZ", ReplyAction="*")]
        System.Threading.Tasks.Task SetZAsync(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetZ", ReplyAction="*")]
        int GetZ();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetZAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddZ", ReplyAction="*")]
        int AddZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddZAsync(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MulZ", ReplyAction="*")]
        int MulZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MulZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulZAsync(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubZ", ReplyAction="*")]
        int SubZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubZAsync(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetAppZ", ReplyAction="*")]
        void SetAppZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetAppZ", ReplyAction="*")]
        System.Threading.Tasks.Task SetAppZAsync(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAppZ", ReplyAction="*")]
        int GetAppZ();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAppZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetAppZAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddAppZ", ReplyAction="*")]
        int AddAppZ(int z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddAppZ", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAppZAsync(int z);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebApplication.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebApplication.ServiceReference1.WebService1Soap>, WebApplication.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Sum(int x, int y) {
            return base.Channel.Sum(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int x, int y) {
            return base.Channel.SumAsync(x, y);
        }
        
        public int Sub(int x, int y) {
            return base.Channel.Sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int x, int y) {
            return base.Channel.SubAsync(x, y);
        }
        
        public int Mul(int x, int y) {
            return base.Channel.Mul(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int x, int y) {
            return base.Channel.MulAsync(x, y);
        }
        
        public void SetZ(int z) {
            base.Channel.SetZ(z);
        }
        
        public System.Threading.Tasks.Task SetZAsync(int z) {
            return base.Channel.SetZAsync(z);
        }
        
        public int GetZ() {
            return base.Channel.GetZ();
        }
        
        public System.Threading.Tasks.Task<int> GetZAsync() {
            return base.Channel.GetZAsync();
        }
        
        public int AddZ(int z) {
            return base.Channel.AddZ(z);
        }
        
        public System.Threading.Tasks.Task<int> AddZAsync(int z) {
            return base.Channel.AddZAsync(z);
        }
        
        public int MulZ(int z) {
            return base.Channel.MulZ(z);
        }
        
        public System.Threading.Tasks.Task<int> MulZAsync(int z) {
            return base.Channel.MulZAsync(z);
        }
        
        public int SubZ(int z) {
            return base.Channel.SubZ(z);
        }
        
        public System.Threading.Tasks.Task<int> SubZAsync(int z) {
            return base.Channel.SubZAsync(z);
        }
        
        public void SetAppZ(int z) {
            base.Channel.SetAppZ(z);
        }
        
        public System.Threading.Tasks.Task SetAppZAsync(int z) {
            return base.Channel.SetAppZAsync(z);
        }
        
        public int GetAppZ() {
            return base.Channel.GetAppZ();
        }
        
        public System.Threading.Tasks.Task<int> GetAppZAsync() {
            return base.Channel.GetAppZAsync();
        }
        
        public int AddAppZ(int z) {
            return base.Channel.AddAppZ(z);
        }
        
        public System.Threading.Tasks.Task<int> AddAppZAsync(int z) {
            return base.Channel.AddAppZAsync(z);
        }
    }
}
