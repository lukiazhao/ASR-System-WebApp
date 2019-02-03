using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AsrSystem.Data;
using AsrSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsrSystem.Controllers
{
    /// <summary>
    /// Staff menu listener class generate view pages related to staff features and 
    /// pass Slot list to View part.
    /// </summary>
    [Authorize(Roles = Constants.StaffRole)]
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaffController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SlotTable()
        {
            // filter this staff's created slots
            var staffID = this.User.Identity.Name.Substring(0, User.Identity.Name.IndexOf('@'));   
            List<Slot> slots = await _context.Slot.Where(x => x.StaffID == staffID).ToListAsync();
            ViewData["Message"] = staffID;
            return View(slots);
        }

        /// <summary>
        /// Creates the slot. Method leads to the view page.
        /// </summary>
        /// <returns>The slot.</returns>
        public IActionResult CreateSlot()
        {
            return View();
        }

        /// <summary>
        /// Creates the slot. Method sends the request and update database.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <param name="slot">Slot.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleException]
        public async Task<IActionResult> CreateSlot([Bind("RoomID,StartTime,StaffID")] Slot slot)
        {
            var user = this.User.Identity.Name.Substring(0, 6);
            slot.StaffID = user;
            if (ModelState.IsValid)
            {
                //Check if room is within range
                CheckRoomExistence(slot.RoomID);
                // validate if a staff booked 4 slots already
                CheckStaffExistingSlotsByDay(user, slot.StartTime);
                // Each room can be booked for a maximum of 2 slots per day.
                CheckRoomExistingSlotsByDay(slot.RoomID, slot.StartTime);

                try
                {
                    _context.Add(slot);
                    await _context.SaveChangesAsync();
                }
                catch
                {
                    throw new Exception("Slot already exist."); 
                }

                return RedirectToAction(nameof(SlotTable));
            }

            return View(slot);
        }

        public async Task<IActionResult> RoomTable(DateTime SearchRoomByDate)
        {
            if (SearchRoomByDate != null)
            {
                var rooms = await _context.Room.Where(x => x.Slots.Count(slot => slot.StartTime.Day == SearchRoomByDate.Day) < 2).ToListAsync();

                return View(rooms);
            }
            else
            {
                return View(await _context.Room.ToListAsync());
            }
        }

        public async Task<IActionResult> StaffList()
        {
            return View(await _context.Staff.ToListAsync());
        }

        /// <summary>
        /// Deletes the slot. Lead to the delete view page.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <param name="roomID">Room identifier.</param>
        /// <param name="startTime">Start time.</param>
        [HandleException]
        public async Task<IActionResult> DeleteSlot(string roomID, DateTime startTime)
        {
            var slot = await _context.Slot.FirstOrDefaultAsync(x => x.RoomID == roomID && x.StartTime == startTime);

            if (slot == null)
            {
                return NotFound();
            }

            if (slot.StudentID != null)
                throw new Exception("This slot has been booked by a student.");

            return View(slot);
        }

        /// <summary>
        /// Deletes the confirmed. Send request to database and delete.
        /// </summary>
        /// <returns>The confirmed.</returns>
        /// <param name="roomID">Room identifier.</param>
        /// <param name="startTime">Start time.</param>
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string roomID, DateTime startTime)
        {
            var slot = await _context.Slot.FindAsync(roomID, startTime);
            _context.Slot.Remove(slot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SlotTable));
        }

        /// <summary>
        /// Error this instance. 
        /// </summary>
        /// <returns>The error.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Validation method for business rule
        private void CheckRoomExistingSlotsByDay(string upcomingSlotRoomID,
                                                 DateTime upcomingSlotDateTime)
        {
            if (_context.Slot.Count(slot => slot.RoomID == upcomingSlotRoomID
                    && slot.StartTime.Day == upcomingSlotDateTime.Day) == 2)
            {
                throw new Exception("Each room can only be booked for a maximum of 2 slots per day.");
            }
        }

        //Validation method for business rule
        private void CheckRoomExistence(string roomID)
        {
            if (!_context.Room.Any(x => x.RoomID == roomID))
                throw new Exception("Room doesn't exist");
        }

        // A staff member can book a maximum of 4 slots per day.
        private void CheckStaffExistingSlotsByDay(string staffID,
                                                  DateTime upcomingSlotDateTime)
        {
            if (_context.Slot.Count(slot => slot.StaffID == staffID
                                   && slot.StartTime.Day == upcomingSlotDateTime.Day) == 4)
                throw new Exception("A staff member can book a maximum of 4 slots per day.");
        }

        public IActionResult FAQ()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}