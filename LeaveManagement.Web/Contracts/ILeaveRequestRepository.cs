using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {

        Task<bool> CreateLeaveRequest(LeaveRequestCreateDto model);

        Task<EmployeeLeaveRequestDto> GetMyLeaveDetails();

        Task<LeaveRequestDto?> GetLeaveRequestAsync(int? id); 

        Task<List<LeaveRequest>> GetAllAysnc(string employeeId);

        Task<AdminLeaveRequestDto> GetAdminLeaveRequestList();

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task CancleLeaverequest(int leaveRequestId);
    }
}
