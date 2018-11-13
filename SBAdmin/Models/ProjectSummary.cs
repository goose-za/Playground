using System;
using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class ProjectSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string Organisation { get; set; }
        public string ProjectTitle { get; set; }
        public string Country { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal ProjectDuration { get; set; }
        public string Theme { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string IsAnonymousGrant { get; set; }
        public string AnnonymousReason { get; set; }
    }
}