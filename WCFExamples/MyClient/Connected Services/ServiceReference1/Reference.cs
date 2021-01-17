﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Hello", ReplyAction="http://tempuri.org/IService/HelloResponse")]
        string Hello();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Hello", ReplyAction="http://tempuri.org/IService/HelloResponse")]
        System.IAsyncResult BeginHello(System.AsyncCallback callback, object asyncState);
        
        string EndHello(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MyClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MyClient.ServiceReference1.IService>, MyClient.ServiceReference1.IService {
        
        private BeginOperationDelegate onBeginHelloDelegate;
        
        private EndOperationDelegate onEndHelloDelegate;
        
        private System.Threading.SendOrPostCallback onHelloCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<HelloCompletedEventArgs> HelloCompleted;
        
        public string Hello() {
            return base.Channel.Hello();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHello(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHello(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHello(System.IAsyncResult result) {
            return base.Channel.EndHello(result);
        }
        
        private System.IAsyncResult OnBeginHello(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginHello(callback, asyncState);
        }
        
        private object[] OnEndHello(System.IAsyncResult result) {
            string retVal = this.EndHello(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloCompleted(object state) {
            if ((this.HelloCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloCompleted(this, new HelloCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloAsync() {
            this.HelloAsync(null);
        }
        
        public void HelloAsync(object userState) {
            if ((this.onBeginHelloDelegate == null)) {
                this.onBeginHelloDelegate = new BeginOperationDelegate(this.OnBeginHello);
            }
            if ((this.onEndHelloDelegate == null)) {
                this.onEndHelloDelegate = new EndOperationDelegate(this.OnEndHello);
            }
            if ((this.onHelloCompletedDelegate == null)) {
                this.onHelloCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloCompleted);
            }
            base.InvokeAsync(this.onBeginHelloDelegate, null, this.onEndHelloDelegate, this.onHelloCompletedDelegate, userState);
        }
    }
}