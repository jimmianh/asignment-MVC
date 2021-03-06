//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpringHeroBankClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionHistory", Namespace="http://schemas.datacontract.org/2004/07/SHBankWebService")]
    [System.SerializableAttribute()]
    public partial class TransactionHistory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReceiverAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeField;
        
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
        public double Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiverAccountNumber {
            get {
                return this.ReceiverAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiverAccountNumberField, value) != true)) {
                    this.ReceiverAccountNumberField = value;
                    this.RaisePropertyChanged("ReceiverAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SenderAccountNumber {
            get {
                return this.SenderAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderAccountNumberField, value) != true)) {
                    this.SenderAccountNumberField = value;
                    this.RaisePropertyChanged("SenderAccountNumber");
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
        public int Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/SHBankWebService")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecurityCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
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
        public string AccountNumber {
            get {
                return this.AccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountNumberField, value) != true)) {
                    this.AccountNumberField = value;
                    this.RaisePropertyChanged("AccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecurityCode {
            get {
                return this.SecurityCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SecurityCodeField, value) != true)) {
                    this.SecurityCodeField = value;
                    this.RaisePropertyChanged("SecurityCode");
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
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string accountNumber, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string accountNumber, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transfer", ReplyAction="http://tempuri.org/IService1/TransferResponse")]
        bool Transfer(string token, string receiverAccountNumber, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transfer", ReplyAction="http://tempuri.org/IService1/TransferResponse")]
        System.Threading.Tasks.Task<bool> TransferAsync(string token, string receiverAccountNumber, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        bool Deposit(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        System.Threading.Tasks.Task<bool> DepositAsync(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Withdraw", ReplyAction="http://tempuri.org/IService1/WithdrawResponse")]
        bool Withdraw(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Withdraw", ReplyAction="http://tempuri.org/IService1/WithdrawResponse")]
        System.Threading.Tasks.Task<bool> WithdrawAsync(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindTransactionHistoriesByToken", ReplyAction="http://tempuri.org/IService1/FindTransactionHistoriesByTokenResponse")]
        SpringHeroBankClient.ServiceReference1.TransactionHistory[] FindTransactionHistoriesByToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindTransactionHistoriesByToken", ReplyAction="http://tempuri.org/IService1/FindTransactionHistoriesByTokenResponse")]
        System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.TransactionHistory[]> FindTransactionHistoriesByTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckValidAccount", ReplyAction="http://tempuri.org/IService1/CheckValidAccountResponse")]
        SpringHeroBankClient.ServiceReference1.Account CheckValidAccount(string accountNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckValidAccount", ReplyAction="http://tempuri.org/IService1/CheckValidAccountResponse")]
        System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.Account> CheckValidAccountAsync(string accountNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckToken", ReplyAction="http://tempuri.org/IService1/CheckTokenResponse")]
        SpringHeroBankClient.ServiceReference1.Account CheckToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckToken", ReplyAction="http://tempuri.org/IService1/CheckTokenResponse")]
        System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.Account> CheckTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateToken", ReplyAction="http://tempuri.org/IService1/CreateTokenResponse")]
        string CreateToken(string accountNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateToken", ReplyAction="http://tempuri.org/IService1/CreateTokenResponse")]
        System.Threading.Tasks.Task<string> CreateTokenAsync(string accountNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SpringHeroBankClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SpringHeroBankClient.ServiceReference1.IService1>, SpringHeroBankClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string accountNumber, string code) {
            return base.Channel.Login(accountNumber, code);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string accountNumber, string code) {
            return base.Channel.LoginAsync(accountNumber, code);
        }
        
        public bool Transfer(string token, string receiverAccountNumber, double amount) {
            return base.Channel.Transfer(token, receiverAccountNumber, amount);
        }
        
        public System.Threading.Tasks.Task<bool> TransferAsync(string token, string receiverAccountNumber, double amount) {
            return base.Channel.TransferAsync(token, receiverAccountNumber, amount);
        }
        
        public bool Deposit(string token, double amount) {
            return base.Channel.Deposit(token, amount);
        }
        
        public System.Threading.Tasks.Task<bool> DepositAsync(string token, double amount) {
            return base.Channel.DepositAsync(token, amount);
        }
        
        public bool Withdraw(string token, double amount) {
            return base.Channel.Withdraw(token, amount);
        }
        
        public System.Threading.Tasks.Task<bool> WithdrawAsync(string token, double amount) {
            return base.Channel.WithdrawAsync(token, amount);
        }
        
        public SpringHeroBankClient.ServiceReference1.TransactionHistory[] FindTransactionHistoriesByToken(string token) {
            return base.Channel.FindTransactionHistoriesByToken(token);
        }
        
        public System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.TransactionHistory[]> FindTransactionHistoriesByTokenAsync(string token) {
            return base.Channel.FindTransactionHistoriesByTokenAsync(token);
        }
        
        public SpringHeroBankClient.ServiceReference1.Account CheckValidAccount(string accountNumber) {
            return base.Channel.CheckValidAccount(accountNumber);
        }
        
        public System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.Account> CheckValidAccountAsync(string accountNumber) {
            return base.Channel.CheckValidAccountAsync(accountNumber);
        }
        
        public SpringHeroBankClient.ServiceReference1.Account CheckToken(string token) {
            return base.Channel.CheckToken(token);
        }
        
        public System.Threading.Tasks.Task<SpringHeroBankClient.ServiceReference1.Account> CheckTokenAsync(string token) {
            return base.Channel.CheckTokenAsync(token);
        }
        
        public string CreateToken(string accountNumber) {
            return base.Channel.CreateToken(accountNumber);
        }
        
        public System.Threading.Tasks.Task<string> CreateTokenAsync(string accountNumber) {
            return base.Channel.CreateTokenAsync(accountNumber);
        }
    }
}
