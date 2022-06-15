namespace LeaveManagement.Web.Models
{
    public class LeaveType : BaseLeaveEntity
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }

    }
}
