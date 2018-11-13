using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class FinancialInfoSummary
    {
        [Key]
        public long GrantId { get; set; }
        public int Year1 { get; set; }
        public int Year2 { get; set; }
        public int Total { get; set; }
    }
}