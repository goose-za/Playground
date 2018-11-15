using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class ExpectedChangesSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "What changes (outputs) do you aim to contribute to by the end of the grant?")]
        public string Outputs { get; set; }
        [Display(Name = "Violence against women and girls eliminated & respect for women's bodily integrity and autonomy sustained")]
        public bool VAWEliminated { get; set; }
        [Display(Name = "More women and girls are aware of and can exercise their rights to bodily integrity and freedom from violence.")]
        public bool RightsToBodilyIntegrity { get; set; }
        [Display(Name = "More women and girls can access necessary support and services that respect their diverse needs and identities.")]
        public bool AccessNecessarySupport { get; set; }
        [Display(Name = "Public increasingly supports VAW.")]
        public bool IncreasingSupportOfVAW { get; set; }
        [Display(Name = "Duty-bearers improve and put in place laws and policies to prevent and respond to VAW.")]
        public bool LawsAndPoliciesToPreventAndRespondToVAW { get; set; }
        [Display(Name = "Full economic rights and justice for women protected")]
        public bool EconomicRightsAndJusticeForWomenProtected { get; set; }
        [Display(Name = "More women are aware of their labour and economic rights and organising in the formal and informal economies.")]
        public bool AwareOfLabourAndEconomicRights { get; set; }
        [Display(Name = "Public (including policy and decision makers) increasingly recognises African women's economic contributions and rights.")]
        public bool RecogniseAfricanWomensEconomicContributions { get; set; }
        [Display(Name = "Duty-bearers improve and put in place policies and laws to protect women's economic rights.")]
        public bool PoliciesAndLawsToProtectWomensEconomicRights { get; set; }
        [Display(Name = "Democratic space expanded, inclusive governance and equal political participation of women sustained")]
        public bool ParticipationOfWomenSustained { get; set; }
        [Display(Name = "Civil society and donors are made more aware of gendered challenges, and support strategies around operating space for women's rights organisations and defenders.")]
        public bool AwarenessOfGenderedChallenges { get; set; }
        [Display(Name = "More women from diverse groups participate in policy and decision-making processes at all levels, including in contexts of conflict/peace-building.")]
        public bool ParticipationInPolicyAndDecisionMakingProcesses { get; set; }
        [Display(Name = "Duty-bearers strengthen and implement laws and policies regarding African women's political rights and participation.")]
        public bool LawsAndPoliciesForAfricanWomensPoliticalRights { get; set; }
    }
}