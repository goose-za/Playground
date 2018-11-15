using System.ComponentModel.DataAnnotations;

namespace SBAdmin.Models
{
    public class MandESummary
    {
        [Key]
        public long GrantId { get; set; }
        [Display(Name = "What methods will you use to monitor and evaluate the project? How often will you use them in the course of the project?")]
        public string Methodology { get; set; }
        [Display(Name = "Who is responsible for carrying out these monitoring and evaluation activities?")]
        public string Responsibilities { get; set; }
        [Display(Name = "What are your key learning questions for this project? How will you use these learnings?")]
        public string KeyLearnings { get; set; }
    }
}