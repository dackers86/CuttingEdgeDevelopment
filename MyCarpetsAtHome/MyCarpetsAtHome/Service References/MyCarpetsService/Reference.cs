﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCarpetsAtHome.MyCarpetsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/MyCarpetsService.Entities")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ColourIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Lookup ColoursLookupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Manufacturer ManufacturerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ManufacturerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaterialIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Lookup MaterialsLookupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Range RangeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> RangeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StyleIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Lookup StylesLookupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Lookup TypesLookupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Width[] WidthsField;
        
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
        public int ColourId {
            get {
                return this.ColourIdField;
            }
            set {
                if ((this.ColourIdField.Equals(value) != true)) {
                    this.ColourIdField = value;
                    this.RaisePropertyChanged("ColourId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Lookup ColoursLookup {
            get {
                return this.ColoursLookupField;
            }
            set {
                if ((object.ReferenceEquals(this.ColoursLookupField, value) != true)) {
                    this.ColoursLookupField = value;
                    this.RaisePropertyChanged("ColoursLookup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Manufacturer Manufacturer {
            get {
                return this.ManufacturerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManufacturerField, value) != true)) {
                    this.ManufacturerField = value;
                    this.RaisePropertyChanged("Manufacturer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ManufacturerId {
            get {
                return this.ManufacturerIdField;
            }
            set {
                if ((this.ManufacturerIdField.Equals(value) != true)) {
                    this.ManufacturerIdField = value;
                    this.RaisePropertyChanged("ManufacturerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaterialId {
            get {
                return this.MaterialIdField;
            }
            set {
                if ((this.MaterialIdField.Equals(value) != true)) {
                    this.MaterialIdField = value;
                    this.RaisePropertyChanged("MaterialId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Lookup MaterialsLookup {
            get {
                return this.MaterialsLookupField;
            }
            set {
                if ((object.ReferenceEquals(this.MaterialsLookupField, value) != true)) {
                    this.MaterialsLookupField = value;
                    this.RaisePropertyChanged("MaterialsLookup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Range Range {
            get {
                return this.RangeField;
            }
            set {
                if ((object.ReferenceEquals(this.RangeField, value) != true)) {
                    this.RangeField = value;
                    this.RaisePropertyChanged("Range");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> RangeId {
            get {
                return this.RangeIdField;
            }
            set {
                if ((this.RangeIdField.Equals(value) != true)) {
                    this.RangeIdField = value;
                    this.RaisePropertyChanged("RangeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StyleId {
            get {
                return this.StyleIdField;
            }
            set {
                if ((this.StyleIdField.Equals(value) != true)) {
                    this.StyleIdField = value;
                    this.RaisePropertyChanged("StyleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Lookup StylesLookup {
            get {
                return this.StylesLookupField;
            }
            set {
                if ((object.ReferenceEquals(this.StylesLookupField, value) != true)) {
                    this.StylesLookupField = value;
                    this.RaisePropertyChanged("StylesLookup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Lookup TypesLookup {
            get {
                return this.TypesLookupField;
            }
            set {
                if ((object.ReferenceEquals(this.TypesLookupField, value) != true)) {
                    this.TypesLookupField = value;
                    this.RaisePropertyChanged("TypesLookup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Width[] Widths {
            get {
                return this.WidthsField;
            }
            set {
                if ((object.ReferenceEquals(this.WidthsField, value) != true)) {
                    this.WidthsField = value;
                    this.RaisePropertyChanged("Widths");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lookup", Namespace="http://schemas.datacontract.org/2004/07/MyCarpetsService.Entities")]
    [System.SerializableAttribute()]
    public partial class Lookup : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> LookupIdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> LookupId {
            get {
                return this.LookupIdField;
            }
            set {
                if ((this.LookupIdField.Equals(value) != true)) {
                    this.LookupIdField = value;
                    this.RaisePropertyChanged("LookupId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manufacturer", Namespace="http://schemas.datacontract.org/2004/07/MyCarpetsService.Entities")]
    [System.SerializableAttribute()]
    public partial class Manufacturer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Product[] ProductsField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Product[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Range", Namespace="http://schemas.datacontract.org/2004/07/MyCarpetsService.Entities")]
    [System.SerializableAttribute()]
    public partial class Range : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Product[] ProductsField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Product[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Width", Namespace="http://schemas.datacontract.org/2004/07/MyCarpetsService.Entities")]
    [System.SerializableAttribute()]
    public partial class Width : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyCarpetsAtHome.MyCarpetsService.Lookup LookupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyCarpetsAtHome.MyCarpetsService.Lookup Lookup {
            get {
                return this.LookupField;
            }
            set {
                if ((object.ReferenceEquals(this.LookupField, value) != true)) {
                    this.LookupField = value;
                    this.RaisePropertyChanged("Lookup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyCarpetsService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllProducts", ReplyAction="http://tempuri.org/IService/ReturnAllProductsResponse")]
        MyCarpetsAtHome.MyCarpetsService.Product[] ReturnAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllProducts", ReplyAction="http://tempuri.org/IService/ReturnAllProductsResponse")]
        System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Product[]> ReturnAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllCarpets", ReplyAction="http://tempuri.org/IService/ReturnAllCarpetsResponse")]
        MyCarpetsAtHome.MyCarpetsService.Product[] ReturnAllCarpets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllCarpets", ReplyAction="http://tempuri.org/IService/ReturnAllCarpetsResponse")]
        System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Product[]> ReturnAllCarpetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllLookups", ReplyAction="http://tempuri.org/IService/ReturnAllLookupsResponse")]
        MyCarpetsAtHome.MyCarpetsService.Lookup[] ReturnAllLookups();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReturnAllLookups", ReplyAction="http://tempuri.org/IService/ReturnAllLookupsResponse")]
        System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Lookup[]> ReturnAllLookupsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MyCarpetsAtHome.MyCarpetsService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MyCarpetsAtHome.MyCarpetsService.IService>, MyCarpetsAtHome.MyCarpetsService.IService {
        
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
        
        public MyCarpetsAtHome.MyCarpetsService.Product[] ReturnAllProducts() {
            return base.Channel.ReturnAllProducts();
        }
        
        public System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Product[]> ReturnAllProductsAsync() {
            return base.Channel.ReturnAllProductsAsync();
        }
        
        public MyCarpetsAtHome.MyCarpetsService.Product[] ReturnAllCarpets() {
            return base.Channel.ReturnAllCarpets();
        }
        
        public System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Product[]> ReturnAllCarpetsAsync() {
            return base.Channel.ReturnAllCarpetsAsync();
        }
        
        public MyCarpetsAtHome.MyCarpetsService.Lookup[] ReturnAllLookups() {
            return base.Channel.ReturnAllLookups();
        }
        
        public System.Threading.Tasks.Task<MyCarpetsAtHome.MyCarpetsService.Lookup[]> ReturnAllLookupsAsync() {
            return base.Channel.ReturnAllLookupsAsync();
        }
    }
}
