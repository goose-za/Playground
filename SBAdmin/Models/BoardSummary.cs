using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class BoardSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BoardPosition { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string AffiliatedOrg { get; set; }
        public string Designation { get; set; }
        public int BoardTerm { get; set; }
    }
}