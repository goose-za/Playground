using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class CapacityNeedsSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Systems development (reviews and evaluations, development of organisational policies, manuals and strategic planning ) ")]
        public bool SystemsDevelopment { get; set; }
        [Display(Name = "Governance strengthening (board/staff development,retreats and training) ")]
        public bool GovernanceStrengthening { get; set; }
        [Display(Name = "Organisational step change (change management, identification and recruitment of new/key staff positions, procurement of software/equipment to enable growth) ")]
        public bool OrganisationalStepChange { get; set; }
        [Display(Name = "Fundraising (generating and sustaining diverse financial and material resources) ")]
        public bool Fundraising { get; set; }
        [Display(Name = "Human resources and staffing (having clear policies and procedures that define staff roles and responsibilities, performance, and terms of engagement; staff training and development) ")]
        public bool HRandStaffing { get; set; }
        [Display(Name = "Financial management (managing organisational finances effectively, including accounting, budget projections and preparing budgets and reporting) ")]
        public bool FinancialManagement { get; set; }
        [Display(Name = "Monitoring, Learning and evaluation (measuring and analysing progress and outcomes of the organisation's work) ")]
        public bool MonitoringLearningAndEvaluation { get; set; }
        [Display(Name = "Marketing/communication (communicating effectively with internal and external audiences, including with media) ")]
        public bool MarketingAndCommunication { get; set; }
        [Display(Name = "Community outreach and networking (developing or strengthening partnerships and alliances with other organisations and communities)")]
        public bool CommunityOutreachAndNetworking { get; set; }
    }
}