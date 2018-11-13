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
        private string GenerateQuery(string viewType, long grantId)
        {
            try
            {
                string queryString = string.Empty;
                queryString = string.Format("SELECT * FROM [vw{0}] WHERE GrantId = {1} ORDER BY GrantId DESC", viewType, grantId);

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
            // TODO: replace hard coded query string with dynamically generated query string
            List<GrantInfoSummary> summaryData = _ctx.Database.SqlQuery<GrantInfoSummary>
                (qryGrantInfoSummary).ToList();

            return View("GrantSummary", summaryData);
        }

        public ActionResult GrantSummary()
        {
            // TODO: replace hard coded query string with dynamically generated query string
            List<AccountingRecordsSummary> accountingRecordsData = _ctx.Database.SqlQuery<AccountingRecordsSummary>(qryAccountingRecordsSummary).ToList();
            List<BeneficiarySummary> beneficiaryData = _ctx.Database.SqlQuery<BeneficiarySummary>(qryBeneficiarySummary).ToList();
            List<BoardSummary> boardDataData = _ctx.Database.SqlQuery<BoardSummary>(qryBoardSummary).ToList();
            List<CapacityNeedsSummary> capacityNeedsData = _ctx.Database.SqlQuery<CapacityNeedsSummary>(qryCapacityNeedsSummary).ToList();
            List<ExpectedChangesSummary> expectedChangesData = _ctx.Database.SqlQuery<ExpectedChangesSummary>(qryExpectedChangesSummary).ToList();
            List<FinancialInfoSummary> financialInfoData = _ctx.Database.SqlQuery<FinancialInfoSummary>(qryFinancialInfoSummary).ToList();
            List<GrantInfoSummary> grantInfoData = _ctx.Database.SqlQuery<GrantInfoSummary>(qryGrantInfoSummary).ToList();
            List<GrantRequestInfoSummary> grantRequestInfoData = _ctx.Database.SqlQuery<GrantRequestInfoSummary>(qryGrantRequestInfoSummary).ToList();
            List<InternalControlsSummary> internalControlsData = _ctx.Database.SqlQuery<InternalControlsSummary>(qryInternalControlsSummary).ToList();
            List<MandESummary> mandEData = _ctx.Database.SqlQuery<MandESummary>(qryMandESummary).ToList();
            List<ProjectSummary> projectData = _ctx.Database.SqlQuery<ProjectSummary>(qryProjectSummary).ToList();
            List<RiskAssessmentSummary> riskAssessmentData = _ctx.Database.SqlQuery<RiskAssessmentSummary>(qryRiskAssessmentSummary).ToList();
            List<StaffSummary> staffData = _ctx.Database.SqlQuery<StaffSummary>(qryStaffSummary).ToList();

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