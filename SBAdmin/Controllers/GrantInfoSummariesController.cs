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
    public class GrantInfoSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: GrantInfoSummaries
        public ActionResult Index()
        {
            string qryString = "SELECT * FROM [vwGrantInfoSummary] WHERE [Status] IN ('New', 'In Progress', 'Pending') ORDER BY GrantId DESC";
            List<GrantInfoSummary> summaryData = db.Database.SqlQuery<GrantInfoSummary>
                (qryString).ToList();

            string qryStringTotals = "SELECT * from vwGrantTotalSummary";
            GrantTotals totals = db.Database.SqlQuery<GrantTotals>
                (qryStringTotals).ToList().FirstOrDefault();

            PODashboardSummary po = new PODashboardSummary
            {
                GrantInfoSummary = summaryData,
                GrantTotals = totals
            };

            return View("Index", po);
        }

        // GET: GrantInfoSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            GrantInfoSummary data = new GrantInfoSummary();
            data = (GrantInfoSummary)GetItemDetails("GrantInfoSummary", id, db);


            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult Details(GrantInfoSummary gis)
        {
            GrantInfoSummary data = gis;
            var bob = gis.GrantId;

            return View(data);
        }

        // GET: GrantInfoSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrantInfoSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Organisation,RequestReason,ProjectObjectives")] GrantInfoSummary grantInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.GrantInfoSummaries.Add(grantInfoSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grantInfoSummary);
        }

        // GET: GrantInfoSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            GrantInfoSummary data = new GrantInfoSummary();
            data = (GrantInfoSummary)GetItemDetails("GrantInfoSummary", id, db);

            
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // POST: GrantInfoSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Organisation,RequestReason,ProjectObjectives")] GrantInfoSummary grantInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grantInfoSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grantInfoSummary);
        }

        // GET: GrantInfoSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantInfoSummary grantInfoSummary = db.GrantInfoSummaries.Find(id);
            if (grantInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(grantInfoSummary);
        }

        // POST: GrantInfoSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            GrantInfoSummary grantInfoSummary = db.GrantInfoSummaries.Find(id);
            db.GrantInfoSummaries.Remove(grantInfoSummary);
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

        private string GenerateQuery(string viewName, long? grantId)
        {
            try
            {
                if (grantId == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest).ToString();
                }

                string queryString = string.Empty;
                queryString = string.Format("SELECT * FROM [vw{0}] WHERE GrantId = {1} ORDER BY GrantId DESC", viewName, grantId);

                return queryString;
            }
            catch (ArgumentNullException ane)
            {
                throw ane;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object GetItemDetails(string ViewName, long? Id, AimsDbContext ctx)
        {
            try
            {
                if (Id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest).ToString();
                }

                string queryString = string.Empty;
                queryString = string.Format("SELECT * FROM [vw{0}] WHERE GrantId = {1} ORDER BY GrantId DESC", ViewName, Id);

                object item = new object();

                // awful code that needs to be refactored
                switch (ViewName)
                {
                    case "AccountingRecordsSummary":
                        item = ctx.Database.SqlQuery<AccountingRecordsSummary>(GenerateQuery("AccountingRecordsSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "BeneficiarySummary":
                        item = ctx.Database.SqlQuery<BeneficiarySummary>(GenerateQuery("BeneficiarySummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "BoardSummary":
                        item = ctx.Database.SqlQuery<BoardSummary>(GenerateQuery("BoardSummary", Id)).ToList();
                        return item;
                    case "CapacityNeedsSummary":
                        item = ctx.Database.SqlQuery<CapacityNeedsSummary>(GenerateQuery("CapacityNeedsSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "ExpectedChangesSummary":
                        item = ctx.Database.SqlQuery<ExpectedChangesSummary>(GenerateQuery("ExpectedChangesSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "FinancialInfoSummary":
                        item = ctx.Database.SqlQuery<FinancialInfoSummary>(GenerateQuery("FinancialInfoSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "GrantInfoSummary":
                        item = ctx.Database.SqlQuery<GrantInfoSummary>(GenerateQuery("GrantInfoSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "GrantRequestInfoSummary":
                        item = ctx.Database.SqlQuery<GrantRequestInfoSummary>(GenerateQuery("GrantRequestInfoSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "InternalControlsSummary":
                        item = ctx.Database.SqlQuery<InternalControlsSummary>(GenerateQuery("InternalControlsSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "MandESummary":
                        item = ctx.Database.SqlQuery<MandESummary>(GenerateQuery("MandESummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "ProjectSummary":
                        item = ctx.Database.SqlQuery<ProjectSummary>(GenerateQuery("ProjectSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "RiskAssessmentSummary":
                        item = ctx.Database.SqlQuery<RiskAssessmentSummary>(GenerateQuery("RiskAssessmentSummary", Id)).ToList().FirstOrDefault();
                        return item;
                    case "StaffSummary":
                        item = ctx.Database.SqlQuery<StaffSummary>(GenerateQuery("StaffSummary", Id)).ToList();
                        return item;
                    default:
                        return null;
                }
            }
            catch (ArgumentNullException ane)
            {
                throw ane;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
