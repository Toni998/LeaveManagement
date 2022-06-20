namespace LeaveManagement.Web.Models.Dtos
{
    public class LeaveAllocationEditDto : LeaveAllocationDto
    {
        public string EmployeeId { get; set; } = null!;

        public int LeaveTypeId { get; set; } 

        public EmployeeListDto? Employee { get; set; }
    }
}
