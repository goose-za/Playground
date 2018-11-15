using System;
using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class ProjectSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "What is the name of your organisation?")]
        public string Organisation { get; set; }
        [Display(Name = "Title of proposed project")]
        public string ProjectTitle { get; set; }
        [Display(Name = "Country you are registered in")]
        public string Country { get; set; }
        [Display(Name = "Requested amount")]
        public decimal RequestedAmount { get; set; }
        [Display(Name = "Project duration")]
        public decimal ProjectDuration { get; set; }
        [Display(Name = "Theme the proposed project addresses")]
        public string Theme { get; set; }
        [Display(Name = "Date of application ")]
        public DateTime ApplicationDate { get; set; }
        [Display(Name = "Do you wish your grant to remain annonymous to the public for safety or security reasons?")]
        public string IsAnonymousGrant { get; set; }
        [Display(Name = "Why do you wish your grant to remain annonymous?")]
        public string AnnonymousReason { get; set; }
    }
}