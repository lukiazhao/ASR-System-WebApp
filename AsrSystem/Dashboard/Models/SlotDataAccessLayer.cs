using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Models
{
    public class SlotDataAccessLayer
    {
        private readonly s3681602Context db = new s3681602Context();

        public IEnumerable<Slot> GetAllSlots()
        {
            return db.Slot.ToList();
        }

        public Object GetSlotData(string key)
        {
            var keys = key.Split('_');
            var roomId = keys[0];
            var startTime = keys[1];
            var slot = db.Slot.Where(x => x.RoomId == roomId && x.StartTime == Convert.ToDateTime(startTime))
                .Select(x => new { x.RoomId, x.StartTime, x.StaffId, x.StudentId}).FirstOrDefault();
            return slot;
        }

        public int UpdateSlot(Slot slot)
        {
            db.Entry(slot).State = EntityState.Modified;
            db.SaveChanges();
            return 1;
        }

        public int AddSlot(Slot slot)
        {
            db.Slot.Add(slot);
            db.SaveChanges();
            return 1;
        }

        public int DeleteSlot(string key)
        {
            //var emp = db.Employee.Find(id);
            var keys = key.Split('_');
            var roomId = keys[0];
            var startTime = keys[1];
            db.Slot.Remove(db.Slot.Where(x => x.RoomId == roomId && x.StartTime == Convert.ToDateTime(startTime)).FirstOrDefault());
            db.SaveChanges();
            return 1;
        }
    }
}
