using SBAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SBAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AimsDbContext _ctx;
        
        private readonly string qryAccountingRecordsSummary = "SELECT * FROM vwAccountingRecordsSummary ORDER BY GrantId DESC";
        private readonly string qryBeneficiarySummary = "SELECT * FROM [vwBeneficiarySummary] ORDER BY GrantId DESC";
        private readonly string qryBoardSummary = "SELECT * FROM [vwBoardSummary] ORDER BY GrantId DESC";
        private readonly string qryCapacityNeedsSummary = "SELECT * FROM [vwCapacityNeedsSummary] ORDER BY GrantId DESC";
        private readonly string qryExpectedChangesSummary = "SELECT * FROM [vwExpectedChangesSummary] ORDER BY GrantId DESC";
        private readonly string qryFinancialInfoSummary = "SELECT * FROM [vwFinancialInfoSummary] ORDER BY GrantId DESC";
        private readonly string qryGrantInfoSummary = "SELECT * FROM [vwGrantInfoSummary] ORDER BY GrantId DESC";
        private readonly string qryGrantRequestInfoSummary = "SELECT * FROM [vwGrantRequestInfoSummary] ORDER BY GrantId DESC";
        private readonly string qryInternalControlsSummary = "SELECT * FROM [vwInternalControlsSummary] ORDER BY GrantId DESC";
        private readonly string qryMandESummary = "SELECT * FROM [vwMandESummary] ORDER BY GrantId DESC";
        private readonly string qryProjectSummary = "SELECT * FROM [vwProjectSummary] ORDER BY GrantId DESC";
        private readonly string qryRiskAssessmentSummary = "SELECT * FROM [vwRiskAssessmentSummary] ORDER BY GrantId DESC";
        private readonly string qryStaffSummary = "SELECT * FROM [vwStaffSummary] ORDER BY GrantId DESC";
        
        // TODO: Log error and show error page
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
            string qryString = "SELECT * FROM [vwGrantInfoSummary] ORDER BY GrantId DESC";
            List<GrantInfoSummary> summaryData = _ctx.Database.SqlQuery<GrantInfoSummary>
                (qryString).ToList();

            return View("GrantSummary", summaryData);
        }

        public ActionResult GrantSummary(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            GrantSummary model = new GrantSummary();
                        
            model.AccountingRecordsSummary = (AccountingRecordsSummary)GetItemDetails("AccountingRecordsSummary", id, _ctx);
            model.BeneficiarySummary = (BeneficiarySummary)GetItemDetails("BeneficiarySummary", id, _ctx);
            model.BoardSummary = (IEnumerable<BoardSummary>)GetItemDetails("BoardSummary", id, _ctx);
            model.CapacityNeedsSummary = (CapacityNeedsSummary)GetItemDetails("CapacityNeedsSummary", id, _ctx);
            model.ExpectedChangesSummary = (ExpectedChangesSummary)GetItemDetails("ExpectedChangesSummary", id, _ctx);
            model.FinancialInfoSummary = (FinancialInfoSummary)GetItemDetails("FinancialInfoSummary", id, _ctx);
            model.GrantInfoSummary = (GrantInfoSummary)GetItemDetails("GrantInfoSummary", id, _ctx);
            model.GrantRequestInfoSummary = (GrantRequestInfoSummary)GetItemDetails("GrantRequestInfoSummary", id, _ctx);
            model.InternalControlsSummary = (InternalControlsSummary)GetItemDetails("InternalControlsSummary", id, _ctx);
            model.MandESummary = (MandESummary)GetItemDetails("MandESummary", id, _ctx);
            model.ProjectSummary = (ProjectSummary)GetItemDetails("ProjectSummary", id, _ctx);
            model.RiskAssessmentSummary = (RiskAssessmentSummary)GetItemDetails("RiskAssessmentSummary", id, _ctx);
            model.StaffSummary = (IEnumerable<StaffSummary>)GetItemDetails("StaffSummary", id, _ctx);
            
            if (model == null)
            {
                return HttpNotFound();
            }

            return View("GrantSummary", model);
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