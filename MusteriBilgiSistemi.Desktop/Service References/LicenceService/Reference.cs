//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriBilgiSistemi.Desktop.LicenceService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LicenceService.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since message CheckLicenceRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckLicence", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse CheckLicence(MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckLicence", ReplyAction="*")]
        System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse> CheckLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest request);
        
        // CODEGEN: Generating message contract since message RegisterLicenceRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterLicence", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse RegisterLicence(MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterLicence", ReplyAction="*")]
        System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse> RegisterLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string loginField;
        
        private string pwdField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("Login");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Pwd {
            get {
                return this.pwdField;
            }
            set {
                this.pwdField = value;
                this.RaisePropertyChanged("Pwd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class LicencePack : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid productKeyField;
        
        private string hddNoField;
        
        private string[] macListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid ProductKey {
            get {
                return this.productKeyField;
            }
            set {
                this.productKeyField = value;
                this.RaisePropertyChanged("ProductKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string HddNo {
            get {
                return this.hddNoField;
            }
            set {
                this.hddNoField = value;
                this.RaisePropertyChanged("HddNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public string[] MacList {
            get {
                return this.macListField;
            }
            set {
                this.macListField = value;
                this.RaisePropertyChanged("MacList");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckLicence", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckLicenceRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp;
        
        public CheckLicenceRequest() {
        }
        
        public CheckLicenceRequest(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            this.AuthHeader = AuthHeader;
            this.lp = lp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckLicenceResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckLicenceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int CheckLicenceResult;
        
        public CheckLicenceResponse() {
        }
        
        public CheckLicenceResponse(int CheckLicenceResult) {
            this.CheckLicenceResult = CheckLicenceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterLicence", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RegisterLicenceRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp;
        
        public RegisterLicenceRequest() {
        }
        
        public RegisterLicenceRequest(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            this.AuthHeader = AuthHeader;
            this.lp = lp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterLicenceResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RegisterLicenceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int RegisterLicenceResult;
        
        public RegisterLicenceResponse() {
        }
        
        public RegisterLicenceResponse(int RegisterLicenceResult) {
            this.RegisterLicenceResult = RegisterLicenceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap>, MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap.CheckLicence(MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest request) {
            return base.Channel.CheckLicence(request);
        }
        
        public int CheckLicence(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest inValue = new MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.lp = lp;
            MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse retVal = ((MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap)(this)).CheckLicence(inValue);
            return retVal.CheckLicenceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse> MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap.CheckLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest request) {
            return base.Channel.CheckLicenceAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceResponse> CheckLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest inValue = new MusteriBilgiSistemi.Desktop.LicenceService.CheckLicenceRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.lp = lp;
            return ((MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap)(this)).CheckLicenceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap.RegisterLicence(MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest request) {
            return base.Channel.RegisterLicence(request);
        }
        
        public int RegisterLicence(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest inValue = new MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.lp = lp;
            MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse retVal = ((MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap)(this)).RegisterLicence(inValue);
            return retVal.RegisterLicenceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse> MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap.RegisterLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest request) {
            return base.Channel.RegisterLicenceAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceResponse> RegisterLicenceAsync(MusteriBilgiSistemi.Desktop.LicenceService.AuthHeader AuthHeader, MusteriBilgiSistemi.Desktop.LicenceService.LicencePack lp) {
            MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest inValue = new MusteriBilgiSistemi.Desktop.LicenceService.RegisterLicenceRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.lp = lp;
            return ((MusteriBilgiSistemi.Desktop.LicenceService.Service1Soap)(this)).RegisterLicenceAsync(inValue);
        }
    }
}
