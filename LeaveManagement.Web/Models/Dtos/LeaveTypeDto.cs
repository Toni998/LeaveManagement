using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.Dtos
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Leave Type name ")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Default number of days")]
        public string DefaultDays { get; set; } = string.Empty;
    }
}
