using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class AccountingRecordsSummary
    {
        [Key]
        public long GrantId { get; set; }
        public bool Cashbook { get; set; }
        public bool PettyCashbook { get; set; }
        public bool ExpendituresFile { get; set; }
        public bool IncomingFundsFile { get; set; }
        public bool BankAccountFile { get; set; }
        public bool FixedAssetRegister { get; set; }
        public bool PayrollRecords { get; set; }
        public bool GeneralLedgerNominalLedger { get; set; }
        public bool AccountsPayablePurchaseLedger { get; set; }
        public bool AccountsReceivableSalesLedger { get; set; }
        public bool AdditionalAccountingRecords { get; set; }
        public bool FinStatementsApproved { get; set; }
        public string FSADate { get; set; }
    }
}