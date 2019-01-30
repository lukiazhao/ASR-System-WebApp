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
    }
}
