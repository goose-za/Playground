using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dashboard
        public ActionResult Dashboard()
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