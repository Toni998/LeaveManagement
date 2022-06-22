using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation> 
    {
        Task LeaveAllocation(int leaveTypeId);

        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationDto> GetAllocationAsync(string id);

        Task<LeaveAllocation?> GetAllocationAsync(string employeeId, int leaveTypeId);

        Task<LeaveAllocationEditDto> GetEmployeeAllocationAsync(int id);
    }
}
