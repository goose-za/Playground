using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class FinancialInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "Year 1")]
        public int Year1 { get; set; }
        [Display(Name = "Year 2")]
        public int Year2 { get; set; }
        [Display(Name = "Grant Total")]
        public int Total { get; set; }
    }
}