using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AsrSystem.Models
{
    public class StudentSlotTableViewModel
    {
        public IEnumerable<Slot> Slots { get; set; }

        [DisplayName("Check Staff Availability: ")]
        public string SelectedStaffID { get; set; }

        [DisplayName("Staff Name    Staff ID")]
        public IEnumerable<String> StaffIDNames { get; set; }
    }
}
