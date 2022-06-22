using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LeaveManagement.Web.GenericRepositories
{
    public class LeaveRequestRepository : GenericRepositroy<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public LeaveRequestRepository(ApplicationDbContext context, 
            IMapper mapper 
            , IHttpContextAccessor httpContext
            ,UserManager<Employee> userManager
            ,ILeaveAllocationRepository leaveAllocationRepository)  : base(context)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task CancleLeaverequest(int leaveRequestId)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Canclled = true;
            await UpdateAsync(leaveRequest);
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;

            if(approved)
            {
                //TO DO
                var allocation = await _leaveAllocationRepository.GetAllocationAsync(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberOfDays -= daysRequested;
                
                await _leaveAllocationRepository.UpdateAsync(allocation);
            }


                await UpdateAsync(leaveRequest);
  
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateDto model)
        {
            //get the user
            var user = await _userManager.GetUserAsync(_httpContext.HttpContext?.User);

            var leaveAllocation = await _leaveAllocationRepository.GetAllocationAsync(user.Id, model.LeaveTypeId);
            if(leaveAllocation == null)
            {
                return false;
            }
            int daysRequired = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;

            if(daysRequired >  leaveAllocation.NumberOfDays)
            {
                return false;
            }


            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

            return true;
               
        }

        public async Task<AdminLeaveRequestDto> GetAdminLeaveRequestList()
        {
            var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestDto
            {
                TotalRequests = leaveRequests.Count(),
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q=> q.Approved == null),
                RejectedRequests = leaveRequests.Count(q=>q.Approved == false),
                LeaveRequests = _mapper.Map<List<LeaveRequestDto>>(leaveRequests)
            };

            foreach (var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = _mapper.Map<EmployeeListDto>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }

            return model;
        }

        public async Task<List<LeaveRequest>> GetAllAysnc(string employeeId)
        {
            return await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<LeaveRequestDto?> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await _context.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id);
            if(leaveRequest == null)
            {
                return null;
            }

            var model = _mapper.Map<LeaveRequestDto>(leaveRequest);
            model.Employee = _mapper.Map<EmployeeListDto>(await _userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
            return model;
        }

        public async Task<EmployeeLeaveRequestDto> GetMyLeaveDetails()
        {
            //get the employee
            var user = await _userManager.GetUserAsync(_httpContext?.HttpContext?.User);
            var allocations = (await _leaveAllocationRepository.GetAllocationAsync(user.Id)).LeaveAllocations;
            var requests = _mapper.Map<List<LeaveRequestDto>>(await GetAllAysnc(user.Id));

            var model = new EmployeeLeaveRequestDto(allocations, requests);

            return model;
        }
    }
}
