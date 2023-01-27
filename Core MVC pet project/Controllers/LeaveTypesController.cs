using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core_MVC_pet_project.Data;
using AutoMapper;
using Core_MVC_pet_project.Models;
using ILeaveTypeRepository = Core_MVC_pet_project.Contracts.ILeaveTypeRepository;

namespace Core_MVC_pet_project.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper imapper;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper imapper)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.imapper = imapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            return View( imapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync()));
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            
            if (leaveType == null)
            {
                return NotFound();
            }
            var leavetypeVM = imapper.Map<LeaveTypeVM>(leaveType);
            return View(leavetypeVM);
        }
    

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = imapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leavetypeVM = imapper.Map<LeaveTypeVM>(leaveType);
            return View(leavetypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = imapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(id))
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
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{

        //    var leaveType = await leaveTypeRepository.DeleteAsync(
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {   
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
