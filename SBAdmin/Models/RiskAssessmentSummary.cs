using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class RiskAssessmentSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Financial Risks")]
        public string FinancialRisks { get; set; }
        [Display(Name = "Probability of Financial Risks")]
        public string FinancialRiskProbability { get; set; }
        [Display(Name = "Financial Risk Mitigation Measures")]
        public string FinancialRiskMitigationMeasures { get; set; }
        [Display(Name = "Legal Risks")]
        public string LegalRisks { get; set; }
        [Display(Name = "Probability of Legal Risks")]
        public string LegalRiskProbability { get; set; }
        [Display(Name = "Legal Risk Mitigation Measures")]
        public string LegalRiskMitigationMeasures { get; set; }
        [Display(Name = "Political Risks")]
        public string PoliticalRisks { get; set; }
        [Display(Name = "Probability of Political Risks")]
        public string PoliticalRiskProbability { get; set; }
        [Display(Name = "Political Risk Mitigation Measures")]
        public string PoliticalRiskMitigationMeasures { get; set; }
        [Display(Name = "Tech Systems Risks")]
        public string TechSystemsRisks { get; set; }
        [Display(Name = "Probability of Tech Systems Risks")]
        public string TechSystemsRiskProbability { get; set; }
        [Display(Name = "Tech Systems Risk Mitigation Measures")]
        public string TechSystemsRiskMitigationMeasures { get; set; }
        [Display(Name = "Human Resources Risks")]
        public string HumanResourcesRisks { get; set; }
        [Display(Name = "Probability of Human Resources Risks")]
        public string HumanResourcesRiskProbability { get; set; }
        [Display(Name = "Human Resources Risk Mitigation Measures")]
        public string HumanResourcesRiskMitigationMeasures { get; set; }
        [Display(Name = "Reputation Risks")]
        public string ReputationRisks { get; set; }
        [Display(Name = "Probability of Reputation Risks")]
        public string ReputationRiskProbability { get; set; }
        [Display(Name = "Reputation Risk Mitigation Measures")]
        public string ReputationRiskMitigationMeasures { get; set; }
    }
}