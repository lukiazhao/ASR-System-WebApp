using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }
    }
}