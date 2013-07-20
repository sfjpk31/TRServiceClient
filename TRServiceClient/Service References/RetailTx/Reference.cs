﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRServiceClient.RetailTx {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.harrahs.com/requestHarrahsServiceImpl", ConfigurationName="RetailTx.InfoGuestTrnx_HTTP_Port")]
    public interface InfoGuestTrnx_HTTP_Port {
        
        // CODEGEN: Generating message contract since the operation getGuestInfo is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="/GuestInfoTransactions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        TRServiceClient.RetailTx.getGuestInfoResponse getGuestInfo(TRServiceClient.RetailTx.getGuestInfoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class GuestInfoRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string accountNumberField;
        
        private string searchTypeField;
        
        private string transactionIDField;
        
        private string emailField;
        
        private string phoneField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string sourceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
                this.RaisePropertyChanged("accountNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string searchType {
            get {
                return this.searchTypeField;
            }
            set {
                this.searchTypeField = value;
                this.RaisePropertyChanged("searchType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string transactionID {
            get {
                return this.transactionIDField;
            }
            set {
                this.transactionIDField = value;
                this.RaisePropertyChanged("transactionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
                this.RaisePropertyChanged("phone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
                this.RaisePropertyChanged("firstName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("lastName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
                this.RaisePropertyChanged("source");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class GuestInfoResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resultStatus resultStatusField;
        
        private string resultCodeField;
        
        private string resultMessageField;
        
        private string transactionIDField;
        
        private string countField;
        
        private guest[] guestsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public resultStatus resultStatus {
            get {
                return this.resultStatusField;
            }
            set {
                this.resultStatusField = value;
                this.RaisePropertyChanged("resultStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string resultCode {
            get {
                return this.resultCodeField;
            }
            set {
                this.resultCodeField = value;
                this.RaisePropertyChanged("resultCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string resultMessage {
            get {
                return this.resultMessageField;
            }
            set {
                this.resultMessageField = value;
                this.RaisePropertyChanged("resultMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string transactionID {
            get {
                return this.transactionIDField;
            }
            set {
                this.transactionIDField = value;
                this.RaisePropertyChanged("transactionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("count");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("guest", IsNullable=false)]
        public guest[] guests {
            get {
                return this.guestsField;
            }
            set {
                this.guestsField = value;
                this.RaisePropertyChanged("guests");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class resultStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resultStatusSTAT sTATField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public resultStatusSTAT STAT {
            get {
                return this.sTATField;
            }
            set {
                this.sTATField = value;
                this.RaisePropertyChanged("STAT");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public enum resultStatusSTAT {
        
        /// <remarks/>
        SUCCESS,
        
        /// <remarks/>
        FAILURE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class guest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string accountNumberField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private tier tierField;
        
        private address addressField;
        
        private string emailField;
        
        private string phoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
                this.RaisePropertyChanged("accountNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
                this.RaisePropertyChanged("firstName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("lastName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public tier tier {
            get {
                return this.tierField;
            }
            set {
                this.tierField = value;
                this.RaisePropertyChanged("tier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public address address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
                this.RaisePropertyChanged("phone");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class tier : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tierCodeField;
        
        private string tierDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string tierCode {
            get {
                return this.tierCodeField;
            }
            set {
                this.tierCodeField = value;
                this.RaisePropertyChanged("tierCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tierDescription {
            get {
                return this.tierDescriptionField;
            }
            set {
                this.tierDescriptionField = value;
                this.RaisePropertyChanged("tierDescription");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.harrahs.com")]
    public partial class address : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string address1Field;
        
        private string address2Field;
        
        private string cityField;
        
        private string stateCodeField;
        
        private string postalCodeField;
        
        private string countryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
                this.RaisePropertyChanged("address1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
                this.RaisePropertyChanged("address2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string stateCode {
            get {
                return this.stateCodeField;
            }
            set {
                this.stateCodeField = value;
                this.RaisePropertyChanged("stateCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("postalCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
                this.RaisePropertyChanged("countryCode");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGuestInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.harrahs.com", Order=0)]
        public TRServiceClient.RetailTx.GuestInfoRequest GuestInfoRequest;
        
        public getGuestInfoRequest() {
        }
        
        public getGuestInfoRequest(TRServiceClient.RetailTx.GuestInfoRequest GuestInfoRequest) {
            this.GuestInfoRequest = GuestInfoRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGuestInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.harrahs.com", Order=0)]
        public TRServiceClient.RetailTx.GuestInfoResponse GuestInfoResponse;
        
        public getGuestInfoResponse() {
        }
        
        public getGuestInfoResponse(TRServiceClient.RetailTx.GuestInfoResponse GuestInfoResponse) {
            this.GuestInfoResponse = GuestInfoResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface InfoGuestTrnx_HTTP_PortChannel : TRServiceClient.RetailTx.InfoGuestTrnx_HTTP_Port, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class InfoGuestTrnx_HTTP_PortClient : System.ServiceModel.ClientBase<TRServiceClient.RetailTx.InfoGuestTrnx_HTTP_Port>, TRServiceClient.RetailTx.InfoGuestTrnx_HTTP_Port {
        
        public InfoGuestTrnx_HTTP_PortClient() {
        }
        
        public InfoGuestTrnx_HTTP_PortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfoGuestTrnx_HTTP_PortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoGuestTrnx_HTTP_PortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoGuestTrnx_HTTP_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TRServiceClient.RetailTx.getGuestInfoResponse TRServiceClient.RetailTx.InfoGuestTrnx_HTTP_Port.getGuestInfo(TRServiceClient.RetailTx.getGuestInfoRequest request) {
            return base.Channel.getGuestInfo(request);
        }
        
        public TRServiceClient.RetailTx.GuestInfoResponse getGuestInfo(TRServiceClient.RetailTx.GuestInfoRequest GuestInfoRequest) {
            TRServiceClient.RetailTx.getGuestInfoRequest inValue = new TRServiceClient.RetailTx.getGuestInfoRequest();
            inValue.GuestInfoRequest = GuestInfoRequest;
            TRServiceClient.RetailTx.getGuestInfoResponse retVal = ((TRServiceClient.RetailTx.InfoGuestTrnx_HTTP_Port)(this)).getGuestInfo(inValue);
            return retVal.GuestInfoResponse;
        }
    }
}