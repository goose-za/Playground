using System;
using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class InternalControlsSummary
    {
        [Key]
        public long GrantId { get; set; }
        public bool ExpenditureAuthorisedUsingPaymentVoucher { get; set; }
        public bool InvoicesCheckedAgainstOrders { get; set; }
        public bool RecordsOfOrdersPlace { get; set; }
        public bool QualityAndQuantityChecked { get; set; }
        public bool PaymentsMadeAgainstOriginalInvoices { get; set; }
        public bool RegularStockTakingUndertaken { get; set; }
        public bool ConditionsForChequesComplied { get; set; }
        public bool MultipeignatoriesOnBankMandate { get; set; }
        public bool ChequeExpenditureNoted { get; set; }
        public bool ChequeStubsCompleted { get; set; }
        public bool ChequesSignedWithDocumentaryEvidence { get; set; }
        public bool PettyCashPaymentsHaveDocumentation { get; set; }
        public bool SupportingDocumentationAuthorised { get; set; }
        public bool ClaimAmountsEntered { get; set; }
        public bool PaymentsNotedInPettyCashBook { get; set; }
        public bool ToppingUpWithdrawalsNotedInPettyCashBook { get; set; }
        public bool RegularChecksOfPettyCashRecords { get; set; }
        public bool BankBccountsHeldInNameOfOrganisation { get; set; }
        public bool InstructionsToOpenCloseAccountsAuthorised { get; set; }
        public bool SecureRecordsHeld { get; set; }
        public bool RegularBankReconciliationsPerformed { get; set; }
        public bool BankStatementsInspected { get; set; }
        public bool SalaryLevelsAuthorised { get; set; }
        public bool StaffEmployedUnderContract { get; set; }
        public bool ComplianceWithStatutoryTaxRegulations { get; set; }
        public bool AssetsCheckedRegularly { get; set; }
        public bool InsuranceCover { get; set; }
        public bool UseOfFixedAssetsReviewed { get; set; }
        public bool ProduceFinancialStatements { get; set; }
        public string PeriodRecentStatements { get; set; }
        public string ReceiversOfFinancialStatements { get; set; }
        public bool AnnualFinancialStatementsAudited { get; set; }
        public string LastExternalAudit { get; set; }
        public DateTime LastExternalAuditDate { get; set; }
        public bool FinancialReportsForManagers { get; set; }
        public string ManagerReportFrequency { get; set; }
        public string ManagerReportCoveragePeriod { get; set; }
        public string ManagerReportCreator { get; set; }
        public bool PeriodicReportsForDonors { get; set; }
        public string DonorReportFrequency { get; set; }
        public string DonorReportCreator { get; set; }
        public string DonorReportReceivers { get; set; }
    }
}