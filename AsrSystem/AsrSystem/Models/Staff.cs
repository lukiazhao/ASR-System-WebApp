using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    public class Staff
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StaffID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
