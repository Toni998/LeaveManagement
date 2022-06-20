namespace LeaveManagement.Web.Models.Dtos
{
    public class EmployeeAllocationDto : EmployeeListDto
    {

        public List<LeaveAllocationDto> LeaveAllocations { get; set; }
    }
}
