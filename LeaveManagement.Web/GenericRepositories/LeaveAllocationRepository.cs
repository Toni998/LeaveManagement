using AutoMapper;
using LeaveManagement.Web.Contants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.GenericRepositories
{
    public class LeaveAllocationRepository :  GenericRepositroy<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveType;
        private readonly IMapper _mapper;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveType,
            IMapper mapper) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _leaveType = leaveType;
            _mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
                                                            && q.LeaveTypeId == leaveTypeId
                                                            && q.Period == period);
               
        }

        public async Task<EmployeeAllocationDto> GetAllocationAsync(string id)
        {
            var allocations = await _context.LeaveAllocations
                .Include(q=> q.LeaveType)
                .Where(q => q.EmployeeId == id).ToListAsync();
            var employee = await _userManager.FindByIdAsync(id);    

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationDto>(employee);
            employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationDto>>(allocations);

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocation?> GetAllocationAsync(string employeeId, int leaveTypeId)
        {

                var model = await _context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
                if(model == null)
            {
                return model;
            }

            return model;            
        }

        public async Task<LeaveAllocationEditDto> GetEmployeeAllocationAsync(int id)
        {
            var allocations = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
               .FirstOrDefaultAsync(q=> q.Id == id);
            
            if(allocations ==null)
            {
                return null;
            } 
            
            var employee = await _userManager.FindByIdAsync(allocations.EmployeeId);

            var model = _mapper.Map<LeaveAllocationEditDto>(allocations);
            model.Employee = _mapper.Map<EmployeeListDto>(await _userManager.FindByIdAsync(allocations.EmployeeId));
            return model;

        }




        //add allocation
        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees =  await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType =await _leaveType.GetAsync(leaveTypeId);

            var allocations = new List<LeaveAllocation>();
     
            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;


                 allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });

                

            }
            await AddRangeAysnc(allocations);

        }
    }
}
