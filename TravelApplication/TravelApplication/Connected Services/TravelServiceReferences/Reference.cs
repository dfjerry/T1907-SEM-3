﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelApplication.TravelServiceReferences {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/TravelService")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Image[] ImagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Post[] PostsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public TravelApplication.TravelServiceReferences.Image[] Images {
            get {
                return this.ImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagesField, value) != true)) {
                    this.ImagesField = value;
                    this.RaisePropertyChanged("Images");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocationAddress {
            get {
                return this.LocationAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationAddressField, value) != true)) {
                    this.LocationAddressField = value;
                    this.RaisePropertyChanged("LocationAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocationDescription {
            get {
                return this.LocationDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationDescriptionField, value) != true)) {
                    this.LocationDescriptionField = value;
                    this.RaisePropertyChanged("LocationDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocationName {
            get {
                return this.LocationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationNameField, value) != true)) {
                    this.LocationNameField = value;
                    this.RaisePropertyChanged("LocationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TravelApplication.TravelServiceReferences.Post[] Posts {
            get {
                return this.PostsField;
            }
            set {
                if ((object.ReferenceEquals(this.PostsField, value) != true)) {
                    this.PostsField = value;
                    this.RaisePropertyChanged("Posts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Image", Namespace="http://schemas.datacontract.org/2004/07/TravelService")]
    [System.SerializableAttribute()]
    public partial class Image : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LocationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageurlField;
        
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
        public TravelApplication.TravelServiceReferences.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LocationID {
            get {
                return this.LocationIDField;
            }
            set {
                if ((this.LocationIDField.Equals(value) != true)) {
                    this.LocationIDField = value;
                    this.RaisePropertyChanged("LocationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imageurl {
            get {
                return this.imageurlField;
            }
            set {
                if ((object.ReferenceEquals(this.imageurlField, value) != true)) {
                    this.imageurlField = value;
                    this.RaisePropertyChanged("imageurl");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/TravelService")]
    [System.SerializableAttribute()]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Comment[] CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LocationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PostDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public TravelApplication.TravelServiceReferences.Comment[] Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
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
        public TravelApplication.TravelServiceReferences.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LocationID {
            get {
                return this.LocationIDField;
            }
            set {
                if ((this.LocationIDField.Equals(value) != true)) {
                    this.LocationIDField = value;
                    this.RaisePropertyChanged("LocationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PostDate {
            get {
                return this.PostDateField;
            }
            set {
                if ((this.PostDateField.Equals(value) != true)) {
                    this.PostDateField = value;
                    this.RaisePropertyChanged("PostDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/TravelService")]
    [System.SerializableAttribute()]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CommentDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelApplication.TravelServiceReferences.Post PostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public System.DateTime CommentDate {
            get {
                return this.CommentDateField;
            }
            set {
                if ((this.CommentDateField.Equals(value) != true)) {
                    this.CommentDateField = value;
                    this.RaisePropertyChanged("CommentDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommentInfo {
            get {
                return this.CommentInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentInfoField, value) != true)) {
                    this.CommentInfoField = value;
                    this.RaisePropertyChanged("CommentInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TravelApplication.TravelServiceReferences.Post Post {
            get {
                return this.PostField;
            }
            set {
                if ((object.ReferenceEquals(this.PostField, value) != true)) {
                    this.PostField = value;
                    this.RaisePropertyChanged("Post");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostID {
            get {
                return this.PostIDField;
            }
            set {
                if ((this.PostIDField.Equals(value) != true)) {
                    this.PostIDField = value;
                    this.RaisePropertyChanged("PostID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TravelServiceReferences.ITravelService")]
    public interface ITravelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/GetLocations", ReplyAction="http://tempuri.org/ITravelService/GetLocationsResponse")]
        TravelApplication.TravelServiceReferences.Location[] GetLocations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/GetLocations", ReplyAction="http://tempuri.org/ITravelService/GetLocationsResponse")]
        System.Threading.Tasks.Task<TravelApplication.TravelServiceReferences.Location[]> GetLocationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/AddLocation", ReplyAction="http://tempuri.org/ITravelService/AddLocationResponse")]
        bool AddLocation(TravelApplication.TravelServiceReferences.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/AddLocation", ReplyAction="http://tempuri.org/ITravelService/AddLocationResponse")]
        System.Threading.Tasks.Task<bool> AddLocationAsync(TravelApplication.TravelServiceReferences.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/EditLocation", ReplyAction="http://tempuri.org/ITravelService/EditLocationResponse")]
        bool EditLocation(string id, TravelApplication.TravelServiceReferences.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/EditLocation", ReplyAction="http://tempuri.org/ITravelService/EditLocationResponse")]
        System.Threading.Tasks.Task<bool> EditLocationAsync(string id, TravelApplication.TravelServiceReferences.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/DeleteLocation", ReplyAction="http://tempuri.org/ITravelService/DeleteLocationResponse")]
        bool DeleteLocation(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelService/DeleteLocation", ReplyAction="http://tempuri.org/ITravelService/DeleteLocationResponse")]
        System.Threading.Tasks.Task<bool> DeleteLocationAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITravelServiceChannel : TravelApplication.TravelServiceReferences.ITravelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TravelServiceClient : System.ServiceModel.ClientBase<TravelApplication.TravelServiceReferences.ITravelService>, TravelApplication.TravelServiceReferences.ITravelService {
        
        public TravelServiceClient() {
        }
        
        public TravelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TravelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TravelApplication.TravelServiceReferences.Location[] GetLocations() {
            return base.Channel.GetLocations();
        }
        
        public System.Threading.Tasks.Task<TravelApplication.TravelServiceReferences.Location[]> GetLocationsAsync() {
            return base.Channel.GetLocationsAsync();
        }
        
        public bool AddLocation(TravelApplication.TravelServiceReferences.Location location) {
            return base.Channel.AddLocation(location);
        }
        
        public System.Threading.Tasks.Task<bool> AddLocationAsync(TravelApplication.TravelServiceReferences.Location location) {
            return base.Channel.AddLocationAsync(location);
        }
        
        public bool EditLocation(string id, TravelApplication.TravelServiceReferences.Location location) {
            return base.Channel.EditLocation(id, location);
        }
        
        public System.Threading.Tasks.Task<bool> EditLocationAsync(string id, TravelApplication.TravelServiceReferences.Location location) {
            return base.Channel.EditLocationAsync(id, location);
        }
        
        public bool DeleteLocation(string id) {
            return base.Channel.DeleteLocation(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteLocationAsync(string id) {
            return base.Channel.DeleteLocationAsync(id);
        }
    }
}
