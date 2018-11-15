using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class GrantRequestInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Why are you seeking a grant from the African Women's Development Fund ? ")]
        public string RequestReason { get; set; }
        [Display(Name = "Please state the project objectives.")]
        public string ProjectObjectives { get; set; }
        [Display(Name = "Why is the project important? How will it contribute to advancing women's rights in your region/country/community?")]
        public string ProjectContributions { get; set; }
        [Display(Name = "What is/are the main challenge(s) and injustices faced by women who would be involved in the project? And how does the application address that challenge ?")]
        public string Challenges { get; set; }
        [Display(Name = "Please describe the activities to be undertaken under the project.")]
        public string Activities { get; set; }
    }
}