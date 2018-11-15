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
    public class GrantRequestInfoSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: GrantRequestInfoSummaries
        public ActionResult Index()
        {
            return View(db.GrantRequestInfoSummary.ToList());
        }

        // GET: GrantRequestInfoSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantRequestInfoSummary grantRequestInfoSummary = db.GrantRequestInfoSummary.Find(id);
            if (grantRequestInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(grantRequestInfoSummary);
        }

        // GET: GrantRequestInfoSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrantRequestInfoSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,RequestReason,ProjectObjectives,ProjectContributions,Challenges,Activities")] GrantRequestInfoSummary grantRequestInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.GrantRequestInfoSummary.Add(grantRequestInfoSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grantRequestInfoSummary);
        }

        // GET: GrantRequestInfoSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantRequestInfoSummary grantRequestInfoSummary = db.GrantRequestInfoSummary.Find(id);
            if (grantRequestInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(grantRequestInfoSummary);
        }

        // POST: GrantRequestInfoSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,RequestReason,ProjectObjectives,ProjectContributions,Challenges,Activities")] GrantRequestInfoSummary grantRequestInfoSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grantRequestInfoSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grantRequestInfoSummary);
        }

        // GET: GrantRequestInfoSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantRequestInfoSummary grantRequestInfoSummary = db.GrantRequestInfoSummary.Find(id);
            if (grantRequestInfoSummary == null)
            {
                return HttpNotFound();
            }
            return View(grantRequestInfoSummary);
        }

        // POST: GrantRequestInfoSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            GrantRequestInfoSummary grantRequestInfoSummary = db.GrantRequestInfoSummary.Find(id);
            db.GrantRequestInfoSummary.Remove(grantRequestInfoSummary);
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
