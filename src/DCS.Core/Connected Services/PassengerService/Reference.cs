﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DCS.Core.PassengerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FindPassengerRequest", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    public partial class FindPassengerRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BoardingPassStringField;
        
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
        public string BoardingPassString {
            get {
                return this.BoardingPassStringField;
            }
            set {
                if ((object.ReferenceEquals(this.BoardingPassStringField, value) != true)) {
                    this.BoardingPassStringField = value;
                    this.RaisePropertyChanged("BoardingPassString");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DCS.Core.PassengerService.CheckInResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DCS.Core.PassengerService.FindPassengerResult))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
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
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckInResult", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    public partial class CheckInResult : DCS.Core.PassengerService.Result {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FindPassengerResult", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    public partial class FindPassengerResult : DCS.Core.PassengerService.Result {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DCS.Core.PassengerService.PassengerNameRecord PassengerNameRecordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DCS.Core.PassengerService.PassengerNameRecord PassengerNameRecord {
            get {
                return this.PassengerNameRecordField;
            }
            set {
                if ((object.ReferenceEquals(this.PassengerNameRecordField, value) != true)) {
                    this.PassengerNameRecordField = value;
                    this.RaisePropertyChanged("PassengerNameRecord");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PassengerNameRecord", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    public partial class PassengerNameRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AllowanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CheckedInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DCS.Core.PassengerService.Flight[] FlightsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PriorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TravelClassField;
        
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
        public decimal Allowance {
            get {
                return this.AllowanceField;
            }
            set {
                if ((this.AllowanceField.Equals(value) != true)) {
                    this.AllowanceField = value;
                    this.RaisePropertyChanged("Allowance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CheckedIn {
            get {
                return this.CheckedInField;
            }
            set {
                if ((this.CheckedInField.Equals(value) != true)) {
                    this.CheckedInField = value;
                    this.RaisePropertyChanged("CheckedIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DCS.Core.PassengerService.Flight[] Flights {
            get {
                return this.FlightsField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightsField, value) != true)) {
                    this.FlightsField = value;
                    this.RaisePropertyChanged("Flights");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((this.PriorityField.Equals(value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TravelClass {
            get {
                return this.TravelClassField;
            }
            set {
                if ((object.ReferenceEquals(this.TravelClassField, value) != true)) {
                    this.TravelClassField = value;
                    this.RaisePropertyChanged("TravelClass");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="Sita.Bagdrop.Assignment.Dcs")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlightNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DCS.Core.PassengerService.FlightStatus FlightStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
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
        public string Destination {
            get {
                return this.DestinationField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationField, value) != true)) {
                    this.DestinationField = value;
                    this.RaisePropertyChanged("Destination");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FlightNumber {
            get {
                return this.FlightNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightNumberField, value) != true)) {
                    this.FlightNumberField = value;
                    this.RaisePropertyChanged("FlightNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DCS.Core.PassengerService.FlightStatus FlightStatus {
            get {
                return this.FlightStatusField;
            }
            set {
                if ((this.FlightStatusField.Equals(value) != true)) {
                    this.FlightStatusField = value;
                    this.RaisePropertyChanged("FlightStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FlightStatus", Namespace="http://schemas.datacontract.org/2004/07/Sita.Bagdrop.Assignment.Dcs")]
    public enum FlightStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Closed = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Sita.Bagdrop.Assignment.Dcs", ConfigurationName="PassengerService.IPassengerService")]
    public interface IPassengerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="Sita.Bagdrop.Assignment.Dcs/IPassengerService/FindPassenger", ReplyAction="Sita.Bagdrop.Assignment.Dcs/IPassengerService/FindPassengerResponse")]
        DCS.Core.PassengerService.FindPassengerResult FindPassenger(DCS.Core.PassengerService.FindPassengerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Sita.Bagdrop.Assignment.Dcs/IPassengerService/FindPassenger", ReplyAction="Sita.Bagdrop.Assignment.Dcs/IPassengerService/FindPassengerResponse")]
        System.Threading.Tasks.Task<DCS.Core.PassengerService.FindPassengerResult> FindPassengerAsync(DCS.Core.PassengerService.FindPassengerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Sita.Bagdrop.Assignment.Dcs/IPassengerService/CheckIn", ReplyAction="Sita.Bagdrop.Assignment.Dcs/IPassengerService/CheckInResponse")]
        DCS.Core.PassengerService.CheckInResult CheckIn(System.Guid passengerId, decimal weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="Sita.Bagdrop.Assignment.Dcs/IPassengerService/CheckIn", ReplyAction="Sita.Bagdrop.Assignment.Dcs/IPassengerService/CheckInResponse")]
        System.Threading.Tasks.Task<DCS.Core.PassengerService.CheckInResult> CheckInAsync(System.Guid passengerId, decimal weight);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPassengerServiceChannel : DCS.Core.PassengerService.IPassengerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PassengerServiceClient : System.ServiceModel.ClientBase<DCS.Core.PassengerService.IPassengerService>, DCS.Core.PassengerService.IPassengerService {
        
        public PassengerServiceClient() {
        }
        
        public PassengerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PassengerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DCS.Core.PassengerService.FindPassengerResult FindPassenger(DCS.Core.PassengerService.FindPassengerRequest request) {
            return base.Channel.FindPassenger(request);
        }
        
        public System.Threading.Tasks.Task<DCS.Core.PassengerService.FindPassengerResult> FindPassengerAsync(DCS.Core.PassengerService.FindPassengerRequest request) {
            return base.Channel.FindPassengerAsync(request);
        }
        
        public DCS.Core.PassengerService.CheckInResult CheckIn(System.Guid passengerId, decimal weight) {
            return base.Channel.CheckIn(passengerId, weight);
        }
        
        public System.Threading.Tasks.Task<DCS.Core.PassengerService.CheckInResult> CheckInAsync(System.Guid passengerId, decimal weight) {
            return base.Channel.CheckInAsync(passengerId, weight);
        }
    }
}
