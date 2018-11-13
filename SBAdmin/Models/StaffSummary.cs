using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class StaffSummary
    {
        [Key]
        public long GrantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public string ContractType { get; set; }
    }
}