using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly SlotDataAccessLayer slotDataAccessLayer= new SlotDataAccessLayer();
        private readonly RoomDataAccessLayer roomDataAccessLayer = new RoomDataAccessLayer();

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Slot> Get()
        {
            return slotDataAccessLayer.GetAllSlots(); //.Select(x => new { x.RoomId, x.StartTime, x.StaffId, x.StudentId });
        }

        [HttpPost]
        [Route("CreateSlot")]
        public int CreateSlot([FromBody] Slot slot)
        {
            return slotDataAccessLayer.AddSlot(slot);
        }

        [HttpPut]
        [Route("EditSlot")]
        public int EditSlot([FromBody] Slot slot)
        {
            return slotDataAccessLayer.UpdateSlot(slot);
        }

        [HttpDelete]
        [Route("DeleteSlot")]
        public int DeleteSlot([FromBody] Slot slot)
        {
            return slotDataAccessLayer.DeleteSlot(slot);
        }


        /// <summary>
        ///////////////////// ROOM ////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("GetRooms")]
        public IEnumerable<Room> GetRooms()
        {
            return roomDataAccessLayer.GetAllRooms();
        }

        [HttpPost]
        [Route("CreateRoom")]
        public int CreateRoom([FromBody] Room room)
        {
            return roomDataAccessLayer.AddRoom(room);
        }

        [HttpPut]
        [Route("EditRoom")]
        public int EditRoom([FromBody] Room room)
        {
            return roomDataAccessLayer.UpdateRoom(room);
        }
    }
}