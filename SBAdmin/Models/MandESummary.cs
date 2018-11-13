using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class MandESummary
    {
        [Key]
        public long GrantId { get; set; }
        public string Methodology { get; set; }
        public string Responsibilities { get; set; }
        public string KeyLearnings { get; set; }
    }
}