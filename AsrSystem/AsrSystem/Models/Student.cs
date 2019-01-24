using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    public class Student
    {
        [Required]
        public string StudentID { get; set; }
        
        public string Name { get; set; }
    }
}
