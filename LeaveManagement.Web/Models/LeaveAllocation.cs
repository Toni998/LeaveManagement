using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocation : BaseLeaveEntity
    {
        public int NumberOfDays { get; set; }

        public string? EmployeeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        //number of days for leave 
        public int Period { get; set; }




    }
}
