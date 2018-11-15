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
    public class CapacityNeedsSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: CapacityNeedsSummaries
        public ActionResult Index()
        {
            return View(db.CapacityNeedsSummary.ToList());
        }

        // GET: CapacityNeedsSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacityNeedsSummary capacityNeedsSummary = db.CapacityNeedsSummary.Find(id);
            if (capacityNeedsSummary == null)
            {
                return HttpNotFound();
            }
            return View(capacityNeedsSummary);
        }

        // GET: CapacityNeedsSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapacityNeedsSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,SystemsDevelopment,GovernanceStrengthening,OrganisationalStepChange,Fundraising,HRandStaffing,FinancialManagement,MonitoringLearningAndEvaluation,MarketingAndCommunication,CommunityOutreachAndNetworking")] CapacityNeedsSummary capacityNeedsSummary)
        {
            if (ModelState.IsValid)
            {
                db.CapacityNeedsSummary.Add(capacityNeedsSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capacityNeedsSummary);
        }

        // GET: CapacityNeedsSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacityNeedsSummary capacityNeedsSummary = db.CapacityNeedsSummary.Find(id);
            if (capacityNeedsSummary == null)
            {
                return HttpNotFound();
            }
            return View(capacityNeedsSummary);
        }

        // POST: CapacityNeedsSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,SystemsDevelopment,GovernanceStrengthening,OrganisationalStepChange,Fundraising,HRandStaffing,FinancialManagement,MonitoringLearningAndEvaluation,MarketingAndCommunication,CommunityOutreachAndNetworking")] CapacityNeedsSummary capacityNeedsSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capacityNeedsSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capacityNeedsSummary);
        }

        // GET: CapacityNeedsSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapacityNeedsSummary capacityNeedsSummary = db.CapacityNeedsSummary.Find(id);
            if (capacityNeedsSummary == null)
            {
                return HttpNotFound();
            }
            return View(capacityNeedsSummary);
        }

        // POST: CapacityNeedsSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CapacityNeedsSummary capacityNeedsSummary = db.CapacityNeedsSummary.Find(id);
            db.CapacityNeedsSummary.Remove(capacityNeedsSummary);
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
