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
    public class MandESummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: MandESummaries
        public ActionResult Index()
        {
            return View(db.MandESummary.ToList());
        }

        // GET: MandESummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandESummary mandESummary = db.MandESummary.Find(id);
            if (mandESummary == null)
            {
                return HttpNotFound();
            }
            return View(mandESummary);
        }

        // GET: MandESummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MandESummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,Methodology,Responsibilities,KeyLearnings")] MandESummary mandESummary)
        {
            if (ModelState.IsValid)
            {
                db.MandESummary.Add(mandESummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mandESummary);
        }

        // GET: MandESummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandESummary mandESummary = db.MandESummary.Find(id);
            if (mandESummary == null)
            {
                return HttpNotFound();
            }
            return View(mandESummary);
        }

        // POST: MandESummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,Methodology,Responsibilities,KeyLearnings")] MandESummary mandESummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mandESummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mandESummary);
        }

        // GET: MandESummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandESummary mandESummary = db.MandESummary.Find(id);
            if (mandESummary == null)
            {
                return HttpNotFound();
            }
            return View(mandESummary);
        }

        // POST: MandESummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MandESummary mandESummary = db.MandESummary.Find(id);
            db.MandESummary.Remove(mandESummary);
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
