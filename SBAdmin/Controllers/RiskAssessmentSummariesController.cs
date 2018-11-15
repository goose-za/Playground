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
    public class RiskAssessmentSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: RiskAssessmentSummaries
        public ActionResult Index()
        {
            return View(db.RiskAssessmentSummary.ToList());
        }

        // GET: RiskAssessmentSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskAssessmentSummary riskAssessmentSummary = db.RiskAssessmentSummary.Find(id);
            if (riskAssessmentSummary == null)
            {
                return HttpNotFound();
            }
            return View(riskAssessmentSummary);
        }

        // GET: RiskAssessmentSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskAssessmentSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,FinancialRisks,FinancialRiskProbability,FinancialRiskMitigationMeasures,LegalRisks,LegalRiskProbability,LegalRiskMitigationMeasures,PoliticalRisks,PoliticalRiskProbability,PoliticalRiskMitigationMeasures,TechSystemsRisks,TechSystemsRiskProbability,TechSystemsRiskMitigationMeasures,HumanResourcesRisks,HumanResourcesRiskProbability,HumanResourcesRiskMitigationMeasures,ReputationRisks,ReputationRiskProbability,ReputationRiskMitigationMeasures")] RiskAssessmentSummary riskAssessmentSummary)
        {
            if (ModelState.IsValid)
            {
                db.RiskAssessmentSummary.Add(riskAssessmentSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(riskAssessmentSummary);
        }

        // GET: RiskAssessmentSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskAssessmentSummary riskAssessmentSummary = db.RiskAssessmentSummary.Find(id);
            if (riskAssessmentSummary == null)
            {
                return HttpNotFound();
            }
            return View(riskAssessmentSummary);
        }

        // POST: RiskAssessmentSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,FinancialRisks,FinancialRiskProbability,FinancialRiskMitigationMeasures,LegalRisks,LegalRiskProbability,LegalRiskMitigationMeasures,PoliticalRisks,PoliticalRiskProbability,PoliticalRiskMitigationMeasures,TechSystemsRisks,TechSystemsRiskProbability,TechSystemsRiskMitigationMeasures,HumanResourcesRisks,HumanResourcesRiskProbability,HumanResourcesRiskMitigationMeasures,ReputationRisks,ReputationRiskProbability,ReputationRiskMitigationMeasures")] RiskAssessmentSummary riskAssessmentSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskAssessmentSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(riskAssessmentSummary);
        }

        // GET: RiskAssessmentSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskAssessmentSummary riskAssessmentSummary = db.RiskAssessmentSummary.Find(id);
            if (riskAssessmentSummary == null)
            {
                return HttpNotFound();
            }
            return View(riskAssessmentSummary);
        }

        // POST: RiskAssessmentSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            RiskAssessmentSummary riskAssessmentSummary = db.RiskAssessmentSummary.Find(id);
            db.RiskAssessmentSummary.Remove(riskAssessmentSummary);
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
