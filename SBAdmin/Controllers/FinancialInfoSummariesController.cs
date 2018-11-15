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
    public class FinancialInfoSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: FinancialInfoSummaries
        public ActionResult Index()
        {
            return View(db.FinancialInfoSummary.ToList());
        }

        // GET: FinancialInfoSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialInfoSummary financialInfoSummary = db.FinancialInfoSummary.Find(id);
            if (financialInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(financialInfoSummary);
        }

        // GET: FinancialInfoSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialInfoSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Year1,Year2,Total")] FinancialInfoSummary financialInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.FinancialInfoSummary.Add(financialInfoSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(financialInfoSummary);
        }

        // GET: FinancialInfoSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialInfoSummary financialInfoSummary = db.FinancialInfoSummary.Find(id);
            if (financialInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(financialInfoSummary);
        }

        // POST: FinancialInfoSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Year1,Year2,Total")] FinancialInfoSummary financialInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(financialInfoSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(financialInfoSummary);
        }

        // GET: FinancialInfoSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialInfoSummary financialInfoSummary = db.FinancialInfoSummary.Find(id);
            if (financialInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(financialInfoSummary);
        }

        // POST: FinancialInfoSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FinancialInfoSummary financialInfoSummary = db.FinancialInfoSummary.Find(id);
            db.FinancialInfoSummary.Remove(financialInfoSummary);
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
