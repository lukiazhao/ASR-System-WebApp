using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AsrSystem.Models
{
    public class SlotRoomViewModel
    {
        public Slot Slot { get; set; }
        public List<Room> Rooms { get; set; }
        public string SlotRoom { get; set; }
    }
}
