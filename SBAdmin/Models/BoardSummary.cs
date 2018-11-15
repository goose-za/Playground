using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class BoardSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Board Position")]
        public string BoardPosition { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Affiliated organisation")]
        public string AffiliatedOrg { get; set; }
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Display(Name = "Board Term")]
        public int BoardTerm { get; set; }
    }
}