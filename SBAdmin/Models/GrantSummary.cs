using System.Collections.Generic;

namespace SBAdmin.Models
{
    public class GrantSummary
    {
        public GrantSummary()
        {
        }

        public AccountingRecordsSummary AccountingRecordsSummary { get; set; }
        public BeneficiarySummary BeneficiarySummary { get; set; }
        public IEnumerable<BoardSummary> BoardSummary { get; set; }
        public CapacityNeedsSummary CapacityNeedsSummary { get; set; }
        public ExpectedChangesSummary ExpectedChangesSummary { get; set; }
        public FinancialInfoSummary FinancialInfoSummary { get; set; }
        public GrantInfoSummary GrantInfoSummary { get; set; }
        public GrantRequestInfoSummary GrantRequestInfoSummary { get; set; }
        public InternalControlsSummary InternalControlsSummary { get; set; }
        public MandESummary MandESummary { get; set; }
        public ProjectSummary ProjectSummary { get; set; }
        public RiskAssessmentSummary RiskAssessmentSummary { get; set; }
        public IEnumerable<StaffSummary> StaffSummary { get; set; }
    }
}