using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class GrantInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string Organisation { get; set; }
        public string RequestReason { get; set; }
        public string ProjectObjectives { get; set; }   
    }
}