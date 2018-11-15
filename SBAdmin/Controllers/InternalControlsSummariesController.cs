using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SBAdmin.Models;

namespace SBAdmin.Controllers
{
    public class InternalControlsSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: InternalControlsSummaries
        public ActionResult Index()
        {
            return View(db.InternalControlsSummary.ToList());
        }

        // GET: InternalControlsSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternalControlsSummary internalControlsSummary = db.InternalControlsSummary.Find(id);
            if (internalControlsSummary == null)
            {
                return HttpNotFound();
            }
            return View(internalControlsSummary);
        }

        // GET: InternalControlsSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InternalControlsSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,ExpenditureAuthorisedUsingPaymentVoucher,InvoicesCheckedAgainstOrders,RecordsOfOrdersPlace,QualityAndQuantityChecked,PaymentsMadeAgainstOriginalInvoices,RegularStockTakingUndertaken,ConditionsForChequesComplied,MultipeignatoriesOnBankMandate,ChequeExpenditureNoted,ChequeStubsCompleted,ChequesSignedWithDocumentaryEvidence,PettyCashPaymentsHaveDocumentation,SupportingDocumentationAuthorised,ClaimAmountsEntered,PaymentsNotedInPettyCashBook,ToppingUpWithdrawalsNotedInPettyCashBook,RegularChecksOfPettyCashRecords,BankBccountsHeldInNameOfOrganisation,InstructionsToOpenCloseAccountsAuthorised,SecureRecordsHeld,RegularBankReconciliationsPerformed,BankStatementsInspected,SalaryLevelsAuthorised,StaffEmployedUnderContract,ComplianceWithStatutoryTaxRegulations,AssetsCheckedRegularly,InsuranceCover,UseOfFixedAssetsReviewed,ProduceFinancialStatements,PeriodRecentStatements,ReceiversOfFinancialStatements,AnnualFinancialStatementsAudited,LastExternalAudit,LastExternalAuditDate,FinancialReportsForManagers,ManagerReportFrequency,ManagerReportCoveragePeriod,ManagerReportCreator,PeriodicReportsForDonors,DonorReportFrequency,DonorReportCreator,DonorReportReceivers")] InternalControlsSummary internalControlsSummary)
        {
            if (ModelState.IsValid)
            {
                db.InternalControlsSummary.Add(internalControlsSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(internalControlsSummary);
        }

        // GET: InternalControlsSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternalControlsSummary internalControlsSummary = db.InternalControlsSummary.Find(id);
            if (internalControlsSummary == null)
            {
                return HttpNotFound();
            }
            return View(internalControlsSummary);
        }

        // POST: InternalControlsSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,ExpenditureAuthorisedUsingPaymentVoucher,InvoicesCheckedAgainstOrders,RecordsOfOrdersPlace,QualityAndQuantityChecked,PaymentsMadeAgainstOriginalInvoices,RegularStockTakingUndertaken,ConditionsForChequesComplied,MultipeignatoriesOnBankMandate,ChequeExpenditureNoted,ChequeStubsCompleted,ChequesSignedWithDocumentaryEvidence,PettyCashPaymentsHaveDocumentation,SupportingDocumentationAuthorised,ClaimAmountsEntered,PaymentsNotedInPettyCashBook,ToppingUpWithdrawalsNotedInPettyCashBook,RegularChecksOfPettyCashRecords,BankBccountsHeldInNameOfOrganisation,InstructionsToOpenCloseAccountsAuthorised,SecureRecordsHeld,RegularBankReconciliationsPerformed,BankStatementsInspected,SalaryLevelsAuthorised,StaffEmployedUnderContract,ComplianceWithStatutoryTaxRegulations,AssetsCheckedRegularly,InsuranceCover,UseOfFixedAssetsReviewed,ProduceFinancialStatements,PeriodRecentStatements,ReceiversOfFinancialStatements,AnnualFinancialStatementsAudited,LastExternalAudit,LastExternalAuditDate,FinancialReportsForManagers,ManagerReportFrequency,ManagerReportCoveragePeriod,ManagerReportCreator,PeriodicReportsForDonors,DonorReportFrequency,DonorReportCreator,DonorReportReceivers")] InternalControlsSummary internalControlsSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(internalControlsSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(internalControlsSummary);
        }

        // GET: InternalControlsSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InternalControlsSummary internalControlsSummary = db.InternalControlsSummary.Find(id);
            if (internalControlsSummary == null)
            {
                return HttpNotFound();
            }
            return View(internalControlsSummary);
        }

        // POST: InternalControlsSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            InternalControlsSummary internalControlsSummary = db.InternalControlsSummary.Find(id);
            db.InternalControlsSummary.Remove(internalControlsSummary);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
