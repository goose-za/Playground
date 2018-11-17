using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class GrantTotals
    {
        [Key]
        public int GrantTotal { get; set; }
        public int New { get; set; }
        public int InProgress { get; set; }
        public int Pending { get; set; }
        public int Complete { get; set; }
        public int Rejected { get; set; }
    }
}