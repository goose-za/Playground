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
    public class ProjectSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: ProjectSummaries
        public ActionResult Index()
        {
            return View(db.ProjectSummary.ToList());
        }

        // GET: ProjectSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSummary projectSummary = db.ProjectSummary.Find(id);
            if (projectSummary == null)
            {
                return HttpNotFound();
            }
            return View(projectSummary);
        }

        // GET: ProjectSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Organisation,ProjectTitle,Country,RequestedAmount,ProjectDuration,Theme,ApplicationDate,IsAnonymousGrant,AnnonymousReason")] ProjectSummary projectSummary)
        {
            if (ModelState.IsValid)
            {
                db.ProjectSummary.Add(projectSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectSummary);
        }

        // GET: ProjectSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSummary projectSummary = db.ProjectSummary.Find(id);
            if (projectSummary == null)
            {
                return HttpNotFound();
            }
            return View(projectSummary);
        }

        // POST: ProjectSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Organisation,ProjectTitle,Country,RequestedAmount,ProjectDuration,Theme,ApplicationDate,IsAnonymousGrant,AnnonymousReason")] ProjectSummary projectSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectSummary);
        }

        // GET: ProjectSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSummary projectSummary = db.ProjectSummary.Find(id);
            if (projectSummary == null)
            {
                return HttpNotFound();
            }
            return View(projectSummary);
        }

        // POST: ProjectSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ProjectSummary projectSummary = db.ProjectSummary.Find(id);
            db.ProjectSummary.Remove(projectSummary);
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
