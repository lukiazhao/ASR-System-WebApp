using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AsrSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string StudentID { get; set; }
        public virtual Student Student { get; set; }

        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
