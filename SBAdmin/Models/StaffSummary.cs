using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class StaffSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name = "Full Time/Part Time")]
        public string ContractType { get; set; }
    }
}