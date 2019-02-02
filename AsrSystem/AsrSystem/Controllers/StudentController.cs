using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AsrSystem.Data;
using AsrSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsrSystem.Controllers
{
    [Authorize(Roles = Constants.StudentRole)]
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string staffSearchString)
        {
            StudentSlotTableViewModel studentSlotTableViewModel = new StudentSlotTableViewModel
            {
                StaffIDNames = await _context.Staff.Select(staff => (staff.StaffID + "    " + staff.Name)).ToListAsync()
            };

            if (!String.IsNullOrEmpty(staffSearchString))
            {
                studentSlotTableViewModel.Slots = await _context.Slot.Where(x => x.StudentID == null
                  && x.StaffID == staffSearchString && x.StartTime >= DateTime.Now).ToListAsync();
            }
            else
            {
                studentSlotTableViewModel.Slots = await _context.Slot.Where(x => (x.StudentID == null
                || x.StudentID == CurrentStudent().StudentID) && x.StartTime >= DateTime.Now).ToListAsync();
            }

            return View(studentSlotTableViewModel);
        }

        //just for testing
        [HandleException]
        public async Task<IActionResult> Book(string roomid, DateTime starttime)
        {
            var tartgetSlot = await _context.Slot.FirstOrDefaultAsync(slot => slot.RoomID == roomid
                        && slot.StartTime == starttime);
            ValidateStudentDailyBookingLimit(starttime);
            tartgetSlot.Book(CurrentStudent().StudentID);
            _context.Update(tartgetSlot);
            await _context.SaveChangesAsync();

            return View(tartgetSlot);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelBook(string roomid, DateTime starttime)
        {
            var tartgetSlot = _context.Slot.FirstOrDefault(slot => slot.RoomID == roomid
            && slot.StartTime == starttime);
            tartgetSlot.CancelBook();
            _context.Update(tartgetSlot);
            await _context.SaveChangesAsync();

            return View(await _context.Slot.ToListAsync());
        }

        private bool SlotExist(string roomID, DateTime startTime)
        {
            return _context.Slot.Any(e => e.RoomID == roomID && e.StartTime == startTime);
        }

        private Student CurrentStudent()
        {
            return _context.Student.SingleOrDefault(
            x => x.StudentID == User.Identity.Name.Substring(0, 8));
        }

        private void ValidateStudentDailyBookingLimit(DateTime startTime)
        {
            if(_context.Slot.Any(x => x.StudentID == CurrentStudent().StudentID 
            && x.StartTime.Day == startTime.Day))
            {
                throw new Exception("A student can only book one slot per day.");
            }
        }
    }
}