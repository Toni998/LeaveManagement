using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;
using AutoMapper;
using LeaveManagement.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Web.Contants;

namespace LeaveManagement.Web.Controllers
{
    [Authorize(Roles =Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository _repository;
        private readonly IMapper _mapper;

        public LeaveTypesController(ILeaveTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveType = await _repository.GetAllAsync();
            
            if(leaveType == null)
            {
                return NotFound();
            }
            //map it to dto
            return View(_mapper.Map<IEnumerable<LeaveTypeDto>>(leaveType));
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var leaveType = await _repository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeDto =_mapper.Map<LeaveTypeDto>(leaveType);
            return View(leaveTypeDto);
        }

        
        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( LeaveTypeDto leaveTypeDto)
        {
            
            if (ModelState.IsValid)
            {
                //too add in database we have to pass an leaveType model 
                var leaveType = _mapper.Map<LeaveType>(leaveTypeDto);
                await _repository.AddAsync(leaveType);
                
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeDto);
        }

        
        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await _repository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeDto =_mapper.Map<LeaveTypeDto>(leaveType);
            
            return View(leaveTypeDto);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeDto leaveTypeDto)
        {
            if (id != leaveTypeDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = _mapper.Map<LeaveType>(leaveTypeDto);
                    await _repository.UpdateAsync(leaveType);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await _repository.Exists(leaveTypeDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeDto);
        }


        
        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           await _repository.DeleteAsnyc(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
