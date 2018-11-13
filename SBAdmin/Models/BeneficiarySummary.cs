using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class BeneficiarySummary
    {
        [Key]
        public long GrantId { get; set; }
        public int WomenAndGirlsInGeneral { get; set; }
        public int WomensRightsActivistsDefenders { get; set; }
        public int WomenEntrepreneursBusinessWomen { get; set; }
        public int WomenLivingWithHIV { get; set; }
        public int WomenWithDisabilities { get; set; }
        public int WomenSexWorkers { get; set; }
        public int IndigenousEthnicMinorityWomen { get; set; }
        public int LesbianBisexualTransgenderWomen { get; set; }
        public int Widows { get; set; }
        public int OrphansAndVulnerableGirls { get; set; }
        public int OutOfSchoolGirls { get; set; }
        public int MarginalisedRuralWomenAndGirls { get; set; }
        public int MarginalisedUrbanWomenAndGirls { get; set; }
        public int WomenAndGirlRefugeesInternallyDisplacedAsylumSeekers { get; set; }
        public int WomenInTheArtsCreativeSectors { get; set; }
        public int WomenInPoliticsAndDecisionMaking { get; set; }
        public int WomenInMedia { get; set; }
        public int WomenTraditionalLeaders { get; set; }
        public int WomenInTechnology { get; set; }
        public int WomenInMiningAffectedCommunities { get; set; }
        public int WomenInAgricultureFarming { get; set; }
        public int WomenGirlSurvivorsOfViolence { get; set; }
        public int TotalBeneficiaries { get; set; }
        public int GirlsAndAdolescentGirls { get; set; }
        public int YoungWomen { get; set; }
        public int Women { get; set; }
        public int BoysAndAdolescentBoys { get; set; }
        public int YoungMen { get; set; }
        public int Men { get; set; }
        public int TransOrIntersexYouthOrAdults { get; set; }
        public int TotalDirectBeneficiaries { get; set; }
        public int CommunityBasedOrganisations { get; set; }
        public int EducationProfessionals { get; set; }
        public int FaithBasedLeaders { get; set; }
        public int GovernmentOfficials { get; set; }
        public int HealthProfessionals { get; set; }
        public int CivilSocietyOrganisations { get; set; }
        public int JournalistsMedia { get; set; }
        public int LegalOfficers { get; set; }
        public int WomenAndOrGirls { get; set; }
        public int MenAndOrBoys { get; set; }
        public int Parliamentarians { get; set; }
        public int SocialWelfareWorkers { get; set; }
        public int SecuritySectorPersonnel { get; set; }
        public int OthersSecondaryBeneficiaries { get; set; }
        public int TotalSecondaryBeneficiaries { get; set; }
    }
}