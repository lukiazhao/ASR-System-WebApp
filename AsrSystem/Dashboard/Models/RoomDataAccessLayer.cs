using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Models
{
    public class RoomDataAccessLayer
    {
        private readonly s3681602Context db = new s3681602Context();

        public IEnumerable<Room> GetAllRooms()
        {
            return db.Room.ToList();
        }

        public int AddRoom(Room room)
        {
            db.Room.Add(room);
            db.SaveChanges();
            return 1;
        }

        public int UpdateRoom(RoomUpdateInfoModel roomInfo)
        {
            var oldRoomId = roomInfo.OldRoomId;
            var newRoom = roomInfo.NewRoom;

            // check if old room 
            var count = db.Room.Where(x => x.RoomId == oldRoomId).FirstOrDefault().Slot.Count();
            Console.WriteLine("count" + count);
            if (db.Room.Where(x => x.RoomId == oldRoomId).Include(room => room.Slot).FirstOrDefault().Slot.Count() > 0)
            {
                return 2;
            } else
            {
                try
                {
                    db.Room.Add(newRoom);
                    db.Room.Remove(db.Room.Where(x => x.RoomId == oldRoomId).FirstOrDefault());
                    db.SaveChanges();
                    return 1;
                }
                catch
                {
                    return 3;
                }
               
            }
            //var oldRoomId = roomInfo.OldRoomId;
            //var newRoom = roomInfo.NewRoom;
            //Console.WriteLine("RoomDtaAccessLayer=" + oldRoomId + "new= " + newRoom);
            //try
            //{
            //    // add new room and copy the slots of old room to new
            //    newRoom.Slot = db.Room.Where(x => x.RoomId == oldRoomId).Select(y => y.Slot).FirstOrDefault();
            //    newRoom.Slot = newRoom.Slot.Select(slot => { slot.RoomId = newRoom.RoomId; return slot; }).ToList();
            //    db.Room.Add(newRoom);
            //    db.SaveChanges();
            //    return 1; 
            //}
            //catch
            //{
            //    return 2;
            //}

            //db.Entry(room).State = EntityState.Modified;
            //db.SaveChanges();
            //return 1;
        }

        public Object GetRoom(string key)
        {
            return db.Room.Where(room => room.RoomId == key).Select(x => new { x.RoomId }).FirstOrDefault();
        }
    }
}
