﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace FlightBooking.ServiceHotels {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSHotelsSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
    public partial class WSHotels : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getHotelsDisponiblesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getHotelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSHotels() {
            this.Url = global::FlightBooking.Properties.Settings.Default.FlightBooking_ServiceHotels_WSHotels;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getHotelsDisponiblesCompletedEventHandler getHotelsDisponiblesCompleted;
        
        /// <remarks/>
        public event getHotelCompletedEventHandler getHotelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getHotelsDisponibles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resHotel[] getHotelsDisponibles(string ville) {
            object[] results = this.Invoke("getHotelsDisponibles", new object[] {
                        ville});
            return ((resHotel[])(results[0]));
        }
        
        /// <remarks/>
        public void getHotelsDisponiblesAsync(string ville) {
            this.getHotelsDisponiblesAsync(ville, null);
        }
        
        /// <remarks/>
        public void getHotelsDisponiblesAsync(string ville, object userState) {
            if ((this.getHotelsDisponiblesOperationCompleted == null)) {
                this.getHotelsDisponiblesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHotelsDisponiblesOperationCompleted);
            }
            this.InvokeAsync("getHotelsDisponibles", new object[] {
                        ville}, this.getHotelsDisponiblesOperationCompleted, userState);
        }
        
        private void OngetHotelsDisponiblesOperationCompleted(object arg) {
            if ((this.getHotelsDisponiblesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getHotelsDisponiblesCompleted(this, new getHotelsDisponiblesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getHotel", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resHotel getHotel(int idHotel) {
            object[] results = this.Invoke("getHotel", new object[] {
                        idHotel});
            return ((resHotel)(results[0]));
        }
        
        /// <remarks/>
        public void getHotelAsync(int idHotel) {
            this.getHotelAsync(idHotel, null);
        }
        
        /// <remarks/>
        public void getHotelAsync(int idHotel, object userState) {
            if ((this.getHotelOperationCompleted == null)) {
                this.getHotelOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHotelOperationCompleted);
            }
            this.InvokeAsync("getHotel", new object[] {
                        idHotel}, this.getHotelOperationCompleted, userState);
        }
        
        private void OngetHotelOperationCompleted(object arg) {
            if ((this.getHotelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getHotelCompleted(this, new getHotelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class resHotel : ServicedComponent {
        
        private int idHotelField;
        
        private string nomHotelField;
        
        private string descriptionHotelField;
        
        private string villeField;
        
        /// <remarks/>
        public int idHotel {
            get {
                return this.idHotelField;
            }
            set {
                this.idHotelField = value;
            }
        }
        
        /// <remarks/>
        public string nomHotel {
            get {
                return this.nomHotelField;
            }
            set {
                this.nomHotelField = value;
            }
        }
        
        /// <remarks/>
        public string descriptionHotel {
            get {
                return this.descriptionHotelField;
            }
            set {
                this.descriptionHotelField = value;
            }
        }
        
        /// <remarks/>
        public string ville {
            get {
                return this.villeField;
            }
            set {
                this.villeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resHotel))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class ServicedComponent : ContextBoundObject {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServicedComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resHotel))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resHotel))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class MarshalByRefObject {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getHotelsDisponiblesCompletedEventHandler(object sender, getHotelsDisponiblesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getHotelsDisponiblesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getHotelsDisponiblesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resHotel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resHotel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getHotelCompletedEventHandler(object sender, getHotelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getHotelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getHotelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resHotel Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resHotel)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591