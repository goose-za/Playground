using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class AccountingRecordsSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Cashbook")]
        public bool Cashbook { get; set; }
        [Display(Name = "Petty Cashbook")]
        public bool PettyCashbook { get; set; }
        [Display(Name = "A file of invoices/receipts for all expenditures")]
        public bool ExpendituresFile { get; set; }
        [Display(Name = "A file of reciepts/vouchers for incoming funds")]
        public bool IncomingFundsFile { get; set; }
        [Display(Name = "A file of bank statements for each bank account held")]
        public bool BankAccountFile { get; set; }
        [Display(Name = "Fixed Asset Register")]
        public bool FixedAssetRegister { get; set; }
        [Display(Name = "Payroll records")]
        public bool PayrollRecords { get; set; }
        [Display(Name = "General Ledger/Nominal Ledger")]
        public bool GeneralLedgerNominalLedger { get; set; }
        [Display(Name = "Accounts Payable/Purchase Ledger")]
        public bool AccountsPayablePurchaseLedger { get; set; }
        [Display(Name = "Accounts Receivable/Sales Ledger")]
        public bool AccountsReceivableSalesLedger { get; set; }
        [Display(Name = "Other additional accounting records")]
        public bool AdditionalAccountingRecords { get; set; }
        [Display(Name = "Are your financial statements formally approved by Board members at an annual meeting?")]
        public bool FinStatementsApproved { get; set; }
        [Display(Name = "When are your financial statements approved?")]
        public string FSADate { get; set; }
    }
}