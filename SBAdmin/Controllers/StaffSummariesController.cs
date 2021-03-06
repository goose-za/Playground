﻿using System;
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
    public class StaffSummariesController : Controller
    {
        private AimsDbContext db = new AimsDbContext();

        // GET: StaffSummaries
        public ActionResult Index()
        {
            return View(db.StaffSummary.ToList());
        }

        // GET: StaffSummaries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffSummary staffSummary = db.StaffSummary.Find(id);
            if (staffSummary == null)
            {
                return HttpNotFound();
            }
            return View(staffSummary);
        }

        // GET: StaffSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrantId,FirstName,LastName,Gender,JobTitle,ContractType")] StaffSummary staffSummary)
        {
            if (ModelState.IsValid)
            {
                db.StaffSummary.Add(staffSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(staffSummary);
        }

        // GET: StaffSummaries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffSummary staffSummary = db.StaffSummary.Find(id);
            if (staffSummary == null)
            {
                return HttpNotFound();
            }
            return View(staffSummary);
        }

        // POST: StaffSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrantId,FirstName,LastName,Gender,JobTitle,ContractType")] StaffSummary staffSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staffSummary);
        }

        // GET: StaffSummaries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffSummary staffSummary = db.StaffSummary.Find(id);
            if (staffSummary == null)
            {
                return HttpNotFound();
            }
            return View(staffSummary);
        }

        // POST: StaffSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            StaffSummary staffSummary = db.StaffSummary.Find(id);
            db.StaffSummary.Remove(staffSummary);
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
