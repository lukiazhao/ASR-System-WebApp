using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsrSystem.Models;
using AsrSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace AsrSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SlotTable()
        {
            return View(await _context.Slot.ToListAsync());
        }

        public IActionResult FAQ()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task<IActionResult> RoomTable()
        {
            return View(await _context.Room.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
