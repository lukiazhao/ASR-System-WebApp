using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    /// <summary>
    /// Student.
    /// </summary>
    public class Student
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the slots current student booked.
        /// </summary>
        /// <value>The slots.</value>
        public virtual ICollection<Slot> Slots { get; set; }
    }
}
