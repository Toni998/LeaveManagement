using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.Dtos
{
    public class AdminLeaveRequestDto
    {
        [Display(Name ="Total Number Of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name ="Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<LeaveRequestDto> LeaveRequests { get; set; }
    }
}
