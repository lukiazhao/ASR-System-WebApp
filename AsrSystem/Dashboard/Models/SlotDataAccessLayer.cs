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

        public int DeleteSlot(Slot slot)
        {
            //var emp = db.Employee.Find(id);
            db.Slot.Remove(db.Slot.Where(x => x.RoomId == slot.RoomId && x.StartTime == slot.StartTime).FirstOrDefault());
            //db.Slot.Remove(slot)k
            db.SaveChanges();
            return 1;
        }
    }
}
