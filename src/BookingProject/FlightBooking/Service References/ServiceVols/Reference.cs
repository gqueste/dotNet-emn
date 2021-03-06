﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightBooking.ServiceVols {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceVols.WSVolsSoap")]
    public interface WSVolsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVolsDisponibles", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        FlightBooking.ServiceVols.resVol[] getVolsDisponibles(string villeDepart, string villeArrivee, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVolsDisponibles", ReplyAction="*")]
        System.Threading.Tasks.Task<FlightBooking.ServiceVols.resVol[]> getVolsDisponiblesAsync(string villeDepart, string villeArrivee, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVol", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        FlightBooking.ServiceVols.resVol getVol(int idVol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVol", ReplyAction="*")]
        System.Threading.Tasks.Task<FlightBooking.ServiceVols.resVol> getVolAsync(int idVol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVillesDepart", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        string[] getVillesDepart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVillesDepart", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getVillesDepartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVillesArrivee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        string[] getVillesArrivee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getVillesArrivee", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getVillesArriveeAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class resVol : ServicedComponent {
        
        private int idVolField;
        
        private string nomVolField;
        
        private string companieField;
        
        private System.DateTime dateVolField;
        
        private double dureeField;
        
        private string villeDepartField;
        
        private string villeArriveeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int idVol {
            get {
                return this.idVolField;
            }
            set {
                this.idVolField = value;
                this.RaisePropertyChanged("idVol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string nomVol {
            get {
                return this.nomVolField;
            }
            set {
                this.nomVolField = value;
                this.RaisePropertyChanged("nomVol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string companie {
            get {
                return this.companieField;
            }
            set {
                this.companieField = value;
                this.RaisePropertyChanged("companie");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime dateVol {
            get {
                return this.dateVolField;
            }
            set {
                this.dateVolField = value;
                this.RaisePropertyChanged("dateVol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double duree {
            get {
                return this.dureeField;
            }
            set {
                this.dureeField = value;
                this.RaisePropertyChanged("duree");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string villeDepart {
            get {
                return this.villeDepartField;
            }
            set {
                this.villeDepartField = value;
                this.RaisePropertyChanged("villeDepart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string villeArrivee {
            get {
                return this.villeArriveeField;
            }
            set {
                this.villeArriveeField = value;
                this.RaisePropertyChanged("villeArrivee");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resVol))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class ServicedComponent : ContextBoundObject {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServicedComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resVol))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class ContextBoundObject : MarshalByRefObject {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextBoundObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServicedComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resVol))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class MarshalByRefObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSVolsSoapChannel : FlightBooking.ServiceVols.WSVolsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSVolsSoapClient : System.ServiceModel.ClientBase<FlightBooking.ServiceVols.WSVolsSoap>, FlightBooking.ServiceVols.WSVolsSoap {
        
        public WSVolsSoapClient() {
        }
        
        public WSVolsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSVolsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVolsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVolsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FlightBooking.ServiceVols.resVol[] getVolsDisponibles(string villeDepart, string villeArrivee, System.DateTime date) {
            return base.Channel.getVolsDisponibles(villeDepart, villeArrivee, date);
        }
        
        public System.Threading.Tasks.Task<FlightBooking.ServiceVols.resVol[]> getVolsDisponiblesAsync(string villeDepart, string villeArrivee, System.DateTime date) {
            return base.Channel.getVolsDisponiblesAsync(villeDepart, villeArrivee, date);
        }
        
        public FlightBooking.ServiceVols.resVol getVol(int idVol) {
            return base.Channel.getVol(idVol);
        }
        
        public System.Threading.Tasks.Task<FlightBooking.ServiceVols.resVol> getVolAsync(int idVol) {
            return base.Channel.getVolAsync(idVol);
        }
        
        public string[] getVillesDepart() {
            return base.Channel.getVillesDepart();
        }
        
        public System.Threading.Tasks.Task<string[]> getVillesDepartAsync() {
            return base.Channel.getVillesDepartAsync();
        }
        
        public string[] getVillesArrivee() {
            return base.Channel.getVillesArrivee();
        }
        
        public System.Threading.Tasks.Task<string[]> getVillesArriveeAsync() {
            return base.Channel.getVillesArriveeAsync();
        }
    }
}
