using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class GrantRequestInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string RequestReason { get; set; }
        public string ProjectObjectives { get; set; }
        public string ProjectContributions { get; set; }
        public string Challenges { get; set; }
        public string Activities { get; set; }
    }
}