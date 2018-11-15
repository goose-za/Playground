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
    public class ExpectedChangesSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: ExpectedChangesSummaries
        public ActionResult Index()
        {
            return View(db.ExpectedChangesSummary.ToList());
        }

        // GET: ExpectedChangesSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpectedChangesSummary expectedChangesSummary = db.ExpectedChangesSummary.Find(id);
            if (expectedChangesSummary == null)
            {
                return HttpNotFound();
            }
            return View(expectedChangesSummary);
        }

        // GET: ExpectedChangesSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpectedChangesSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Outputs,VAWEliminated,RightsToBodilyIntegrity,AccessNecessarySupport,IncreasingSupportOfVAW,LawsAndPoliciesToPreventAndRespondToVAW,EconomicRightsAndJusticeForWomenProtected,AwareOfLabourAndEconomicRights,RecogniseAfricanWomensEconomicContributions,PoliciesAndLawsToProtectWomensEconomicRights,ParticipationOfWomenSustained,AwarenessOfGenderedChallenges,ParticipationInPolicyAndDecisionMakingProcesses,LawsAndPoliciesForAfricanWomensPoliticalRights")] ExpectedChangesSummary expectedChangesSummary)
        {
            if (ModelState.IsValid)
            {
                db.ExpectedChangesSummary.Add(expectedChangesSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expectedChangesSummary);
        }

        // GET: ExpectedChangesSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpectedChangesSummary expectedChangesSummary = db.ExpectedChangesSummary.Find(id);
            if (expectedChangesSummary == null)
            {
                return HttpNotFound();
            }
            return View(expectedChangesSummary);
        }

        // POST: ExpectedChangesSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Outputs,VAWEliminated,RightsToBodilyIntegrity,AccessNecessarySupport,IncreasingSupportOfVAW,LawsAndPoliciesToPreventAndRespondToVAW,EconomicRightsAndJusticeForWomenProtected,AwareOfLabourAndEconomicRights,RecogniseAfricanWomensEconomicContributions,PoliciesAndLawsToProtectWomensEconomicRights,ParticipationOfWomenSustained,AwarenessOfGenderedChallenges,ParticipationInPolicyAndDecisionMakingProcesses,LawsAndPoliciesForAfricanWomensPoliticalRights")] ExpectedChangesSummary expectedChangesSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expectedChangesSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expectedChangesSummary);
        }

        // GET: ExpectedChangesSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpectedChangesSummary expectedChangesSummary = db.ExpectedChangesSummary.Find(id);
            if (expectedChangesSummary == null)
            {
                return HttpNotFound();
            }
            return View(expectedChangesSummary);
        }

        // POST: ExpectedChangesSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ExpectedChangesSummary expectedChangesSummary = db.ExpectedChangesSummary.Find(id);
            db.ExpectedChangesSummary.Remove(expectedChangesSummary);
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
