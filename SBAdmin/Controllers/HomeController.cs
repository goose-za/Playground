using Newtonsoft.Json;
using SBAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace SBAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AimsDbContext _ctx;
        private HashSet<SectionNote> _sectionNotes; 

        #region Constructors

        public HomeController()
        {
            _ctx = new AimsDbContext();
        }

        #endregion

        #region Actions

        // GET: Home
        public ActionResult Index()
        {
            // check if we have a PODashboardSummary object in the Session
            if (Session["poDashboardData"] == null)
            {
                // we don't, so let's create a new object, populate it and throw it into the session variable
                string qryString = "SELECT * FROM [vwGrantInfoSummary] WHERE [Status] IN ('New', 'In Progress', 'Pending') ORDER BY GrantId DESC";
                List<GrantInfoSummary> summaryData = _ctx.Database.SqlQuery<GrantInfoSummary>
                    (qryString).ToList();

                string qryStringTotals = "SELECT * from vwGrantTotalSummary";
                GrantTotals totals = _ctx.Database.SqlQuery<GrantTotals>
                    (qryStringTotals).ToList().FirstOrDefault();

                PODashboardSummary po = new PODashboardSummary
                {
                    GrantInfoSummary = summaryData,
                    GrantTotals = totals
                };

                Session["poDashboardData"] = po;

                return View("Dashboard", po);
            }
            else
            {
                // we have a PODashboardSummary object in the Session
                // so let's just get it and return the view with the data

                return View("Dashboard", (PODashboardSummary)Session["poDashboardData"]);
            }
        }

        public ActionResult GrantSummary(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // check if we have a GrantSummary object in the Session
            if (Session["grantSummaryData"] == null)
            {
                // we don't, so let's create a new object, populate it and throw it into the session variable
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

                Session["grantSummaryData"] = model;

                return View("GrantSummary", model);
            }
            else
            {
                // we have a GrantSummary object in the Session
                // so let's just get it and return the view with the data

                return View("GrantSummary", (GrantSummary)Session["grantSummaryData"]);
            }
        }

        [HttpPost]
        public ActionResult GrantSummary(GrantSummary grantSummary)
        {
            var identityName = Thread.CurrentPrincipal.Identity.Name;
            string errorParam = string.Empty;

            var grantId = grantSummary.GrantInfoSummary.GrantId;

            string grantNotesJson = Request.Form["grantNotesJson"];
            _sectionNotes = JsonConvert.DeserializeObject<HashSet<SectionNote>>(grantNotesJson);

            using (var ctx = new AimsDbContext())
            {
                // define the SectionNotes data table
                DataTable sectionNotesDt = new DataTable();

                // add columns to dt
                sectionNotesDt.Columns.Add("GrantId", typeof(long));                           // [0]
                sectionNotesDt.Columns.Add("ProjectSummaryNote", typeof(string));              // [1]
                sectionNotesDt.Columns.Add("GrantRequestInfoSummaryNote", typeof(string));     // [2]
                sectionNotesDt.Columns.Add("BeneficiarySummaryNote", typeof(string));          // [3]
                sectionNotesDt.Columns.Add("ExpectedChangesSummaryNote", typeof(string));      // [4]
                sectionNotesDt.Columns.Add("CapacityNeedsSummaryNote", typeof(string));        // [5]
                sectionNotesDt.Columns.Add("RiskAssessmentSummaryNote", typeof(string));       // [6]
                sectionNotesDt.Columns.Add("MandESummaryNote", typeof(string));                // [7]
                sectionNotesDt.Columns.Add("FinancialInfoSummaryNote", typeof(string));        // [8]
                sectionNotesDt.Columns.Add("GovernanceAndHRSummaryNote", typeof(string));      // [9]
                sectionNotesDt.Columns.Add("AccountingRecordsSummaryNote", typeof(string));    // [10]
                sectionNotesDt.Columns.Add("InternalControlsSummaryNote", typeof(string));     // [11]
                sectionNotesDt.Columns.Add("InsertedDateTime", typeof(DateTime));              // [12]
                sectionNotesDt.Columns.Add("InsertedBy", typeof(string));                      // [13]
                sectionNotesDt.Columns.Add("ModifiedDateTime", typeof(DateTime));              // [14]
                sectionNotesDt.Columns.Add("ModifiedBy", typeof(string));                      // [15]

                // create new data row
                DataRow row = sectionNotesDt.NewRow();

                // populate the grant id column
                row[0] = grantId;

                // iterate over the collection of notes 
                foreach (var note in _sectionNotes)
                {
                    // add section note to the related column
                    row[note.SectionId] = note.Text;
                }

                // populate audit data
                row[12] = DateTime.Now;     // InsertedDateTime
                row[13] = identityName;     // InsertedBy
                row[14] = DateTime.Now;     // ModifiedDateTime
                row[15] = identityName;     // ModifiedBy

                // add the row to the data table
                sectionNotesDt.Rows.Add(row);

                // execute the stored proc against the db
                var sql = @"InsertGrantSectionNotes @SectionNotes, @Error OUT";

                var result = ctx.Database.ExecuteSqlCommand(sql,
                    parameters: new[]
                    {
                        new SqlParameter
                        {
                            ParameterName = "@SectionNotes",
                            SqlDbType = SqlDbType.Structured,
                            TypeName = "dbo.udtSectionNotes",
                            Direction = ParameterDirection.Input,
                            Value = sectionNotesDt
                        },
                        new SqlParameter
                        {
                            ParameterName = "@Error",
                            SqlDbType = SqlDbType.NVarChar,
                            Direction = ParameterDirection.Output,
                            Value = errorParam
                        }
                    });

                if(errorParam != string.Empty)
                {
                    throw new SqlExecutionException(errorParam);
                }

                // send the data back to the workflow to send back to the grantee
            }

            if (Session["grantSummaryData"] != null)
            {
                return View("GrantSummary", (GrantSummary)Session["grantSummaryData"]);
            }

            return View();
        }

        #region Sample Pages

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

        #endregion

        #endregion

        #region Private Functions

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

        private PODashboardSummary GetPODashboardData()
        {
            if (Session["poDashboardData"] == null)
            {
                Session["poDashboardData"] = new PODashboardSummary();
            }
            return (PODashboardSummary)Session["poDashboardData"];
        }

        #endregion  
    }
}