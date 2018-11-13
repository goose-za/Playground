using SBAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AimsDbContext _ctx;
        private readonly string query = "SELECT GrantId, Organisation, [RequestReason], [ProjectObjectives] FROM GrantInfosummary ORDER BY GrantId DESC";

        public HomeController()
        {
            _ctx = new AimsDbContext();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dashboard
        public ActionResult Dashboard()
        {
            // connect to db and return the summarised list of all the grants
            List<GrantInfoSummary> summaryData = _ctx.Database.SqlQuery<GrantInfoSummary>
                (query).ToList();

            return View("GrantSummary", summaryData);
        }

        public ActionResult GrantSummary()
        {
            return View();
        }

        // GET: Charts
        public ActionResult Charts()
        {
            return View();
        }

        // GET: Forms
        public ActionResult Forms()
        {
            return View();
        }

        // GET: Tables
        public ActionResult Tables()
        {
            return View();
        }

        // GET: Boot Strap Elements
        public ActionResult BSElements()
        {
            return View();
        }

        // GET: Boot Strap Grid
        public ActionResult BSGrid()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }
    }
}