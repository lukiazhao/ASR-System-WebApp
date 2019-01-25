using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AsrSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AsrSystem.Controllers
{
    [Authorize(Roles = Constants.StudentRole)]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var user = this.User.FindFirstValue(ClaimTypes.Name);
            ViewData["Message"] = user;
            return View();
        }
    }
}