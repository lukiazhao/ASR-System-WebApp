using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsrSystem.Models;
using AsrSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AsrSystem.Controllers
{
    /// <summary>
    /// Home page controller of web app.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) => _context = context;

        //Show login user name on home page
        public IActionResult Index()
        {
            if (User != null)
            {
                var currentUser = _context.Users.FirstOrDefault(x => x.NormalizedUserName == User.Identity.Name);

                return View(currentUser);
            }
            else
            {
                return View(); 
            }
        }
       
        public IActionResult FAQ()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Rooms the table. Filter all room available to create new slot by a given day
        /// </summary>
        /// <returns>The table.</returns>
        /// <param name="SearchRoomByDate">Search room by date.</param>
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

        // Error handle page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Register success page
        public IActionResult RegisterSuccess()
        {
            return View();
        }
    }
}
