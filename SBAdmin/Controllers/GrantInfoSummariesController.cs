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
            return View(db.GrantInfoSummaries.ToList());
        }

        // GET: GrantInfoSummaries/Details/5
        public ActionResult Details(long? id)
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
            GrantInfoSummary grantInfoSummary = db.GrantInfoSummaries.Find(id);
            if (grantInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(grantInfoSummary);
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
    }
}
