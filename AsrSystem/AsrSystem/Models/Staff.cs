using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    public class Staff
    {
        [Required]
        public string StaffID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
