using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class CapacityNeedsSummary
    {
        [Key]
        public long GrantId { get; set; }
        public bool SystemsDevelopment { get; set; }
        public bool GovernanceStrengthening { get; set; }
        public bool OrganisationalStepChange { get; set; }
        public bool Fundraising { get; set; }
        public bool HRandStaffing { get; set; }
        public bool FinancialManagement { get; set; }
        public bool MonitoringLearningAndEvaluation { get; set; }
        public bool MarketingAndCommunication { get; set; }
        public bool CommunityOutreachAndNetworking { get; set; }
    }
}