using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class GrantInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "What is the name of your organisation?")]
        public string Organisation { get; set; }
        [Display(Name = "Why are you seeking a grant from the African Women's Development Fund ? ")]
        public string RequestReason { get; set; }
        [Display(Name = "Please state the project objectives.")]
        public string ProjectObjectives { get; set; }   
    }
}