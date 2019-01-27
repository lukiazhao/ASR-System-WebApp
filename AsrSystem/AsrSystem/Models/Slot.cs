using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    public class Slot
    {
        [Required]
        public string RoomID { get; set; }
        public virtual Room Room { get; set; }

        [DisplayName("Start Time")]
        [Required, DataType(DataType.DateTime)]

        [ValidateDateRange(ErrorMessage = "Slots must be booked between 09:00 to 14:00 in the future")]
        [ValidateHour(ErrorMessage = "Slots should be at the start of the hour, e.g., 10:00am, etc.")]
        public DateTime StartTime { get; set; }

        [Required]
        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }

        public string StudentID { get; set; }
        public virtual Student Student { get; set; }

        public void Book(string studentID) 
        {
            if(StudentID != null)
            {
                throw new Exception(); 
            }
            else
            {
                StudentID = studentID; 
            }
        }

        public void CancelBook()
        {
            if (StudentID != null)
            {
                StudentID = null;
             }
            else
            {
                throw new Exception();
            }
        }
    }
}
