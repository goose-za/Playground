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
    public class BoardSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: BoardSummaries
        public ActionResult Index()
        {
            return View(db.BoardSummary.ToList());
        }

        // GET: BoardSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardSummary boardSummary = db.BoardSummary.Find(id);
            if (boardSummary == null)
            {
                return HttpNotFound();
            }
            return View(boardSummary);
        }

        // GET: BoardSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,FirstName,LastName,BoardPosition,Gender,Address,AffiliatedOrg,Designation,BoardTerm")] BoardSummary boardSummary)
        {
            if (ModelState.IsValid)
            {
                db.BoardSummary.Add(boardSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boardSummary);
        }

        // GET: BoardSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardSummary boardSummary = db.BoardSummary.Find(id);
            if (boardSummary == null)
            {
                return HttpNotFound();
            }
            return View(boardSummary);
        }

        // POST: BoardSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,FirstName,LastName,BoardPosition,Gender,Address,AffiliatedOrg,Designation,BoardTerm")] BoardSummary boardSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boardSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boardSummary);
        }

        // GET: BoardSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardSummary boardSummary = db.BoardSummary.Find(id);
            if (boardSummary == null)
            {
                return HttpNotFound();
            }
            return View(boardSummary);
        }

        // POST: BoardSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            BoardSummary boardSummary = db.BoardSummary.Find(id);
            db.BoardSummary.Remove(boardSummary);
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
