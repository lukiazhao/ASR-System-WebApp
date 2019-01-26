using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    public class SlotManager
    {
        private static SlotManager _slotManager;

        public static SlotManager GetSlotManager()
        {
            if (_slotManager == null) _slotManager = new SlotManager();
            return _slotManager;
        }

        public void RetriveSlotByStaff(string staffEmail)
        {

        }
    }
}
