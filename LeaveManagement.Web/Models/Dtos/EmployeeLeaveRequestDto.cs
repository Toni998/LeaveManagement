namespace LeaveManagement.Web.Models.Dtos
{
    public class EmployeeLeaveRequestDto
    {
        public EmployeeLeaveRequestDto(List<LeaveAllocationDto> leaveAllocations, List<LeaveRequestDto> leaveRequests)
        {
            LeaveAllocations = leaveAllocations;
            LeaveRequests = leaveRequests;
        }
        public List<LeaveAllocationDto> LeaveAllocations { get; set; }

        public List<LeaveRequestDto> LeaveRequests { get; set; }

    }
}
