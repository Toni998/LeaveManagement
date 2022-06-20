using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.Dtos
{
    public class LeaveAllocationDto
    {
        [Required]
        public int Id { get; set; }

        [Display(Name="Number of days")]
        [Required]
        [Range(1,50, ErrorMessage ="Inavlid number entered ")]
        public int NumberOfDays { get; set; }

        [Required]
        public int Period { get; set; }

       
        [Display(Name = "Leave type")]
        public LeaveTypeDto? LeaveType { get; set; }
    }
}