using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class RoomUpdateInfoModel
    {
       public string OldRoomId { get; set; }
       public Room NewRoom { get; set; }
    }
}
