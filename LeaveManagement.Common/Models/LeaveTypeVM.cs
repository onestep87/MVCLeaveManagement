using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1,25, ErrorMessage ="Leave cannot be longer than 25 days")]
        public int DefaultDays { get; set; }
        
    }
}
