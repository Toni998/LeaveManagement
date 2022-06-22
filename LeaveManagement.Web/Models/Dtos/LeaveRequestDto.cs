using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.Dtos
{
    public class LeaveRequestDto :LeaveRequestCreateDto
    {
        public int Id { get; set; }


        [Display(Name = "Leave Type")]
        public LeaveTypeDto LeaveType { get; set; }


        [Display(Name="Date Requested")]
        public DateTime DateRequested { get; set; }



        public bool? Approved { get; set; }
        public bool Canclled { get; set; }

        public string? RequestingEmployeeId { get; set; }
        public EmployeeListDto Employee { get; set; }
    }
}
