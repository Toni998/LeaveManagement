using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.GenericRepositories
{
    public class LeaveTypeRepository : GenericRepositroy<LeaveType>, ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
