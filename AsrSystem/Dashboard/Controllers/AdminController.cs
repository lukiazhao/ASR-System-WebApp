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
        private readonly UserDataAccessLayer userDataAccessLayer = new UserDataAccessLayer();

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
            if (slot.StudentId == "")
            {
                slot.StudentId = null;
            }
            return slotDataAccessLayer.AddSlot(slot);
        }

        [HttpGet]
        [Route("Details/{key}")]
        public Object Details(string key)
        {
            return slotDataAccessLayer.GetSlotData(key);
        }

        [HttpPut]
        [Route("EditSlot")]
        public int EditSlot([FromBody] Slot slot)
        {
            if (slot.StudentId == "")
            {
                slot.StudentId = null;
            }
            return slotDataAccessLayer.UpdateSlot(slot);
        }

        [HttpDelete]
        [Route("DeleteSlot/{key}")]
        public int DeleteSlot(string key)
        {
            
            return slotDataAccessLayer.DeleteSlot(key);
        }
        /// <summary>
        /// /////////////////////////// User//////////////////////
        /// </summary>
        [HttpGet]
        [Route("GetStaff")]
        public IEnumerable<Staff> GetStaff()
        {
            return userDataAccessLayer.GetAllStaff();
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