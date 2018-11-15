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
    public class AccountingRecordsSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: AccountingRecordsSummaries
        public ActionResult Index()
        {
            return View(db.AccountingRecordsSummary.ToList());
        }

        // GET: AccountingRecordsSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingRecordsSummary accountingRecordsSummary = db.AccountingRecordsSummary.Find(id);
            if (accountingRecordsSummary == null)
            {
                return HttpNotFound();
            }
            return View(accountingRecordsSummary);
        }

        // GET: AccountingRecordsSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountingRecordsSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Cashbook,PettyCashbook,ExpendituresFile,IncomingFundsFile,BankAccountFile,FixedAssetRegister,PayrollRecords,GeneralLedgerNominalLedger,AccountsPayablePurchaseLedger,AccountsReceivableSalesLedger,AdditionalAccountingRecords,FinStatementsApproved,FSADate")] AccountingRecordsSummary accountingRecordsSummary)
        {
            if (ModelState.IsValid)
            {
                db.AccountingRecordsSummary.Add(accountingRecordsSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountingRecordsSummary);
        }

        // GET: AccountingRecordsSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingRecordsSummary accountingRecordsSummary = db.AccountingRecordsSummary.Find(id);
            if (accountingRecordsSummary == null)
            {
                return HttpNotFound();
            }
            return View(accountingRecordsSummary);
        }

        // POST: AccountingRecordsSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Cashbook,PettyCashbook,ExpendituresFile,IncomingFundsFile,BankAccountFile,FixedAssetRegister,PayrollRecords,GeneralLedgerNominalLedger,AccountsPayablePurchaseLedger,AccountsReceivableSalesLedger,AdditionalAccountingRecords,FinStatementsApproved,FSADate")] AccountingRecordsSummary accountingRecordsSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountingRecordsSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountingRecordsSummary);
        }

        // GET: AccountingRecordsSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountingRecordsSummary accountingRecordsSummary = db.AccountingRecordsSummary.Find(id);
            if (accountingRecordsSummary == null)
            {
                return HttpNotFound();
            }
            return View(accountingRecordsSummary);
        }

        // POST: AccountingRecordsSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AccountingRecordsSummary accountingRecordsSummary = db.AccountingRecordsSummary.Find(id);
            db.AccountingRecordsSummary.Remove(accountingRecordsSummary);
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
