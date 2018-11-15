using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class BeneficiarySummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Women and girls in general")]
        public int WomenAndGirlsInGeneral { get; set; }
        [Display(Name = "Women's rights activists/defenders")]
        public int WomensRightsActivistsDefenders { get; set; }
        [Display(Name = "Women entrepreneurs/business women (including market women, cross border traders)")]
        public int WomenEntrepreneursBusinessWomen { get; set; }
        [Display(Name = "Women living with HIV")]
        public int WomenLivingWithHIV { get; set; }
        [Display(Name = "Women with disabilities")]
        public int WomenWithDisabilities { get; set; }
        [Display(Name = "Women sex workers")]
        public int WomenSexWorkers { get; set; }
        [Display(Name = "Indigenous/ethnic minority women")]
        public int IndigenousEthnicMinorityWomen { get; set; }
        [Display(Name = "Lesbian, bisexual, transgender women")]
        public int LesbianBisexualTransgenderWomen { get; set; }
        [Display(Name = "Widows")]
        public int Widows { get; set; }
        [Display(Name = "Orphans and vulnerable girls")]
        public int OrphansAndVulnerableGirls { get; set; }
        [Display(Name = "Out of school girls")]
        public int OutOfSchoolGirls { get; set; }
        [Display(Name = "Marginalised rural women and girls")]
        public int MarginalisedRuralWomenAndGirls { get; set; }
        [Display(Name = "Marginalised urban women and girls")]
        public int MarginalisedUrbanWomenAndGirls { get; set; }
        [Display(Name = "Women and girl refugees/internally displaced/asylum seekers")]
        public int WomenAndGirlRefugeesInternallyDisplacedAsylumSeekers { get; set; }
        [Display(Name = "Women in the arts/creative sectors")]
        public int WomenInTheArtsCreativeSectors { get; set; }
        [Display(Name = "Women in politics and decision making")]
        public int WomenInPoliticsAndDecisionMaking { get; set; }
        [Display(Name = "Women in media")]
        public int WomenInMedia { get; set; }
        [Display(Name = "Women traditional leaders")]
        public int WomenTraditionalLeaders { get; set; }
        [Display(Name = "Women in technology")]
        public int WomenInTechnology { get; set; }
        [Display(Name = "Women in mining affected communities")]
        public int WomenInMiningAffectedCommunities { get; set; }
        [Display(Name = "Women in agriculture/farming")]
        public int WomenInAgricultureFarming { get; set; }
        [Display(Name = "Women/girl survivors of violence")]
        public int WomenGirlSurvivorsOfViolence { get; set; }
        [Display(Name = "Total number of beneficiaries")]
        public int TotalBeneficiaries { get; set; }
        [Display(Name = "Girls and adolescent girls (under 18)")]

        public int GirlsAndAdolescentGirls { get; set; }
        [Display(Name = "Young women (18-25)")]
        public int YoungWomen { get; set; }
        [Display(Name = "Women (age 25 and above)")]
        public int Women { get; set; }
        [Display(Name = "Boys and adolescent boys (under 18)")]
        public int BoysAndAdolescentBoys { get; set; }
        [Display(Name = "Young men (18-25)")]
        public int YoungMen { get; set; }
        [Display(Name = "Men (age 25 and above)")]
        public int Men { get; set; }
        [Display(Name = "Trans or intersex youth or adults")]
        public int TransOrIntersexYouthOrAdults { get; set; }
        [Display(Name = "Total direct beneficiaries")]
        public int TotalDirectBeneficiaries { get; set; }

        [Display(Name = "Community based organisations")]
        public int CommunityBasedOrganisations { get; set; }
        [Display(Name = "Education professionals (educators, teachers)")]
        public int EducationProfessionals { get; set; }
        [Display(Name = "Faith based leaders")]
        public int FaithBasedLeaders { get; set; }
        [Display(Name = "Government officials")]
        public int GovernmentOfficials { get; set; }
        [Display(Name = "Health professionals")]
        public int HealthProfessionals { get; set; }
        [Display(Name = "Civil society organisations (including NGO's)")]
        public int CivilSocietyOrganisations { get; set; }
        [Display(Name = "Journalists/media")]
        public int JournalistsMedia { get; set; }
        [Display(Name = "Legal officers")]
        public int LegalOfficers { get; set; }
        [Display(Name = "Women and/or girls")]
        public int WomenAndOrGirls { get; set; }
        [Display(Name = "Men and/or boys")]
        public int MenAndOrBoys { get; set; }
        [Display(Name = "Parliamentarians")]
        public int Parliamentarians { get; set; }
        [Display(Name = "Social/welfare workers")]
        public int SocialWelfareWorkers { get; set; }
        [Display(Name = "Security sector personnel")]
        public int SecuritySectorPersonnel { get; set; }
        [Display(Name = "Others (Please specify)")]
        public int OthersSecondaryBeneficiaries { get; set; }
        [Display(Name = "Total indirect beneficiaries")]
        public int TotalSecondaryBeneficiaries { get; set; }
    }
}