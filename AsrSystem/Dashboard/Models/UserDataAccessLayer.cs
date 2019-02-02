using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class UserDataAccessLayer
    {
        private readonly s3681602Context db = new s3681602Context();

        public IEnumerable<Staff> GetAllStaff()
        {
            return db.Staff.ToList();
        }
    }
}
