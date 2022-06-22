using LeaveManagement.Web.Models.Dtos;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequest : BaseLeaveEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }
        public string? RequestComment { get; set; }


        public bool? Approved { get; set; }
        public bool Canclled { get; set; }

        public string RequestingEmployeeId { get; set; }


    }
}
