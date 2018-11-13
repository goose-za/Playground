using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class ExpectedChangesSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string Outputs { get; set; }
        public bool VAWEliminated { get; set; }
        public bool RightsToBodilyIntegrity { get; set; }
        public bool AccessNecessarySupport { get; set; }
        public bool IncreasingSupportOfVAW { get; set; }
        public bool LawsAndPoliciesToPreventAndRespondToVAW { get; set; }
        public bool EconomicRightsAndJusticeForWomenProtected { get; set; }
        public bool AwareOfLabourAndEconomicRights { get; set; }
        public bool RecogniseAfricanWomensEconomicContributions { get; set; }
        public bool PoliciesAndLawsToProtectWomensEconomicRights { get; set; }
        public bool ParticipationOfWomenSustained { get; set; }
        public bool AwarenessOfGenderedChallenges { get; set; }
        public bool ParticipationInPolicyAndDecisionMakingProcesses { get; set; }
        public bool LawsAndPoliciesForAfricanWomensPoliticalRights { get; set; }
    }
}