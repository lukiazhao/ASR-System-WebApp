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

        // To Update the records of a particular employee.
        public int UpdateRoom(Room room)
        {
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
            return 1;
        }
    }
}
