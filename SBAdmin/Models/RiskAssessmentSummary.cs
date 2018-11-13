using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class RiskAssessmentSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string FinancialRisks { get; set; }
        public string FinancialRiskProbability { get; set; }
        public string FinancialRiskMitigationMeasures { get; set; }
        public string LegalRisks { get; set; }
        public string LegalRiskProbability { get; set; }
        public string LegalRiskMitigationMeasures { get; set; }
        public string PoliticalRisks { get; set; }
        public string PoliticalRiskProbability { get; set; }
        public string PoliticalRiskMitigationMeasures { get; set; }
        public string TechSystemsRisks { get; set; }
        public string TechSystemsRiskProbability { get; set; }
        public string TechSystemsRiskMitigationMeasures { get; set; }
        public string HumanResourcesRisks { get; set; }
        public string HumanResourcesRiskProbability { get; set; }
        public string HumanResourcesRiskMitigationMeasures { get; set; }
        public string ReputationRisks { get; set; }
        public string ReputationRiskProbability { get; set; }
        public string ReputationRiskMitigationMeasures { get; set; }
    }
}