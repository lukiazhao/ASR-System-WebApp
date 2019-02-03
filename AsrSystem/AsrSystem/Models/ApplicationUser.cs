using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AsrSystem.Models
{
    /// <summary>
    /// Application user. Self defined user implementation with role info
    /// Only one type of ID owned by an ApplicationUser
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public string StudentID { get; set; }
        public virtual Student Student { get; set; }

        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
