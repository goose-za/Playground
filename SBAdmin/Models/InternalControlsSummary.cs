using System;
using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class InternalControlsSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Supporting documentation held for all items of expenditure (i.e. invoices, vouchers, receipts) ")]
        public bool SupportingDocumentationForExpenditure { get; set; }
        [Display(Name = "All expenditure properly authorised on a payment voucher ")]
        public bool ExpenditureAuthorisedUsingPaymentVoucher { get; set; }
        [Display(Name = "Invoices checked against orders made ")]
        public bool InvoicesCheckedAgainstOrders { get; set; }
        [Display(Name = "Records kept of orders placed but not carried out ")]
        public bool RecordsOfOrdersPlace { get; set; }
        [Display(Name = "The quality and quantity of goods supplied checked against orders made ")]
        public bool QualityAndQuantityChecked { get; set; }
        [Display(Name = "Payments only made against original invoices (i.e. not only monthly statements or photocopies) ")]
        public bool PaymentsMadeAgainstOriginalInvoices { get; set; }
        [Display(Name = "Regular stock-taking undertaken ")]
        public bool RegularStockTakingUndertaken { get; set; }
        [Display(Name = "Conditions set down in governing document about who can sign cheques complied with ")]
        public bool ConditionsForChequesComplied { get; set; }
        [Display(Name = "At least two signatories on the bank mandate ")]
        public bool MultipeignatoriesOnBankMandate { get; set; }
        [Display(Name = "All cheque expenditure is recorded in the cashbook and noted with the relevant cheque number ")]
        public bool ChequeExpenditureNoted { get; set; }
        [Display(Name = "Cheque stubs are completed at the time of payment ")]
        public bool ChequeStubsCompleted { get; set; }
        [Display(Name = "Cheques are signed only with proper documentary evidence of the nature of the payment")]
        public bool ChequesSignedWithDocumentaryEvidence { get; set; }
        [Display(Name = "All petty cash payments have supporting documentation ")]
        public bool PettyCashPaymentsHaveDocumentation { get; set; }
        [Display(Name = "Supporting documentation authorised by someone other than the cashier or claimant ")]
        public bool SupportingDocumentationAuthorised { get; set; }
        [Display(Name = "Amounts of claim entered on a petty cash voucher ")]
        public bool ClaimAmountsEntered { get; set; }
        [Display(Name = "All payments noted in a petty cash book")]
        public bool PaymentsNotedInPettyCashBook { get; set; }
        [Display(Name = "All topping up withdrawals from bank noted in the petty cash book ")]
        public bool ToppingUpWithdrawalsNotedInPettyCashBook { get; set; }
        [Display(Name = "Regular checks made of petty cash records by someone other than the cashier ")]
        public bool RegularChecksOfPettyCashRecords { get; set; }
        [Display(Name = "All bank accounts are held in the name of the organisation not individuals ")]
        public bool BankBccountsHeldInNameOfOrganisation { get; set; }
        [Display(Name = "Instructions to open or close accounts are properly authorised and/or reported to Trustees of the organisation ")]
        public bool InstructionsToOpenCloseAccountsAuthorised { get; set; }
        [Display(Name = "Secure records are held for all bank accounts ")]
        public bool SecureRecordsHeld { get; set; }
        [Display(Name = "Regular bank reconciliations are carried out ")]
        public bool RegularBankReconciliationsPerformed { get; set; }
        [Display(Name = "Bank statements are regularly inspected by trustees ")]
        public bool BankStatementsInspected { get; set; }
        [Display(Name = "Salary levels are properly authorised and recorded ")]
        public bool SalaryLevelsAuthorised { get; set; }
        [Display(Name = "Staff are employed under a proper contract of employment ")]
        public bool StaffEmployedUnderContract { get; set; }
        [Display(Name = "Compliance with statutory tax regulations are ensured ")]
        public bool ComplianceWithStatutoryTaxRegulations { get; set; }
        [Display(Name = "Are assets checked regularly to ensure that they are still in good condition and in a proper location? ")]
        public bool AssetsCheckedRegularly { get; set; }
        [Display(Name = "Do you have insurance cover for all valuable assets?")]
        public bool InsuranceCover { get; set; }
        [Display(Name = "Is the use of fixed assets reviewed annually to ensure they are put to best use and serving the organisation’s interest?")]
        public bool UseOfFixedAssetsReviewed { get; set; }
        [Display(Name = "Does the organisation produce financial statements (including a Balance Sheet and Profit & Loss or Income & Expenditure account)?")]
        public bool ProduceFinancialStatements { get; set; }
        [Display(Name = "Period covered by most recent statements")]
        public string PeriodRecentStatements { get; set; }
        [Display(Name = "Who receives copies of financial statements?")]
        public string ReceiversOfFinancialStatements { get; set; }
        [Display(Name = "Are the annual financial statements subjected to an independent audit by a qualified professional?")]
        public bool AnnualFinancialStatementsAudited { get; set; }
        [Display(Name = "Who conducted the last external audit?")]
        public string LastExternalAudit { get; set; }
        [Display(Name = "When was the last external audit conducted?")]
        public DateTime LastExternalAuditDate { get; set; }
        [Display(Name = "Does the organisation produce financial reports for MANAGERS which compare performance against budgets?")]
        public bool FinancialReportsForManagers { get; set; }
        [Display(Name = "How often?")]
        public string ManagerReportFrequency { get; set; }
        [Display(Name = "Period covered by most recent report?")]
        public string ManagerReportCoveragePeriod { get; set; }
        [Display(Name = "Who prepares the report? Who receives copies of the report?")]
        public string ManagerReportCreator { get; set; }
        [Display(Name = "Does the organisation produce periodic reports for DONORS which compare performance against budgets?")]
        public bool PeriodicReportsForDonors { get; set; }
        [Display(Name = "How often?")]
        public string DonorReportFrequency { get; set; }
        [Display(Name = "Who prepares the report?")]
        public string DonorReportCreator { get; set; }
        [Display(Name = "Which donors receive copies of the report?")]
        public string DonorReportReceivers { get; set; }
    }
}