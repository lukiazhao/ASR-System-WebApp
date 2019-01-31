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