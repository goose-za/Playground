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
    public class BeneficiarySummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: BeneficiarySummaries
        public ActionResult Index()
        {
            return View(db.BeneficiarySummary.ToList());
        }

        // GET: BeneficiarySummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeneficiarySummary beneficiarySummary = db.BeneficiarySummary.Find(id);
            if (beneficiarySummary == null)
            {
                return HttpNotFound();
            }
            return View(beneficiarySummary);
        }

        // GET: BeneficiarySummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeneficiarySummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,WomenAndGirlsInGeneral,WomensRightsActivistsDefenders,WomenEntrepreneursBusinessWomen,WomenLivingWithHIV,WomenWithDisabilities,WomenSexWorkers,IndigenousEthnicMinorityWomen,LesbianBisexualTransgenderWomen,Widows,OrphansAndVulnerableGirls,OutOfSchoolGirls,MarginalisedRuralWomenAndGirls,MarginalisedUrbanWomenAndGirls,WomenAndGirlRefugeesInternallyDisplacedAsylumSeekers,WomenInTheArtsCreativeSectors,WomenInPoliticsAndDecisionMaking,WomenInMedia,WomenTraditionalLeaders,WomenInTechnology,WomenInMiningAffectedCommunities,WomenInAgricultureFarming,WomenGirlSurvivorsOfViolence,TotalBeneficiaries,GirlsAndAdolescentGirls,YoungWomen,Women,BoysAndAdolescentBoys,YoungMen,Men,TransOrIntersexYouthOrAdults,TotalDirectBeneficiaries,CommunityBasedOrganisations,EducationProfessionals,FaithBasedLeaders,GovernmentOfficials,HealthProfessionals,CivilSocietyOrganisations,JournalistsMedia,LegalOfficers,WomenAndOrGirls,MenAndOrBoys,Parliamentarians,SocialWelfareWorkers,SecuritySectorPersonnel,OthersSecondaryBeneficiaries,TotalSecondaryBeneficiaries")] BeneficiarySummary beneficiarySummary)
        {
            if (ModelState.IsValid)
            {
                db.BeneficiarySummary.Add(beneficiarySummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beneficiarySummary);
        }

        // GET: BeneficiarySummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeneficiarySummary beneficiarySummary = db.BeneficiarySummary.Find(id);
            if (beneficiarySummary == null)
            {
                return HttpNotFound();
            }
            return View(beneficiarySummary);
        }

        // POST: BeneficiarySummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,WomenAndGirlsInGeneral,WomensRightsActivistsDefenders,WomenEntrepreneursBusinessWomen,WomenLivingWithHIV,WomenWithDisabilities,WomenSexWorkers,IndigenousEthnicMinorityWomen,LesbianBisexualTransgenderWomen,Widows,OrphansAndVulnerableGirls,OutOfSchoolGirls,MarginalisedRuralWomenAndGirls,MarginalisedUrbanWomenAndGirls,WomenAndGirlRefugeesInternallyDisplacedAsylumSeekers,WomenInTheArtsCreativeSectors,WomenInPoliticsAndDecisionMaking,WomenInMedia,WomenTraditionalLeaders,WomenInTechnology,WomenInMiningAffectedCommunities,WomenInAgricultureFarming,WomenGirlSurvivorsOfViolence,TotalBeneficiaries,GirlsAndAdolescentGirls,YoungWomen,Women,BoysAndAdolescentBoys,YoungMen,Men,TransOrIntersexYouthOrAdults,TotalDirectBeneficiaries,CommunityBasedOrganisations,EducationProfessionals,FaithBasedLeaders,GovernmentOfficials,HealthProfessionals,CivilSocietyOrganisations,JournalistsMedia,LegalOfficers,WomenAndOrGirls,MenAndOrBoys,Parliamentarians,SocialWelfareWorkers,SecuritySectorPersonnel,OthersSecondaryBeneficiaries,TotalSecondaryBeneficiaries")] BeneficiarySummary beneficiarySummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beneficiarySummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beneficiarySummary);
        }

        // GET: BeneficiarySummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeneficiarySummary beneficiarySummary = db.BeneficiarySummary.Find(id);
            if (beneficiarySummary == null)
            {
                return HttpNotFound();
            }
            return View(beneficiarySummary);
        }

        // POST: BeneficiarySummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            BeneficiarySummary beneficiarySummary = db.BeneficiarySummary.Find(id);
            db.BeneficiarySummary.Remove(beneficiarySummary);
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
