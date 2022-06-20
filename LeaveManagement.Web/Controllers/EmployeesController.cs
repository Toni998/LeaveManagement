using AutoMapper;
using LeaveManagement.Web.Contants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, 
            IMapper mapper
            ,ILeaveAllocationRepository leaveAllocationRepository
            , ILeaveTypeRepository leaveTypeRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            //get all employees
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);

            return View(_mapper.Map<IEnumerable<EmployeeListDto>>(employees));
        }

        // GET: EmployeesController/Details/5
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model =await _leaveAllocationRepository.GetAllocationAsync(id);
           return View(model);
        } 

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocationAsync(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditDto model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var allocation = await _leaveAllocationRepository.GetAsync(model.Id);
                    if(allocation == null)
                    {
                        return NotFound();
                    }
                    allocation.Period = model.Period;
                    allocation.NumberOfDays = model.NumberOfDays;
                    await _leaveAllocationRepository.UpdateAsync(allocation);
                    return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId});
                }
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occured. Try again later");
                
            }
            model.Employee = _mapper.Map<EmployeeListDto>(await _userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = _mapper.Map<LeaveTypeDto>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
