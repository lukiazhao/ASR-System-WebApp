using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slot exceed room daily limit exception.
    /// Indicate business rule: Each room can be booked for a 
    /// maximum of 2 slots per day.
    /// </summary>
    public class SlotExceedRoomDailyLimitException : Exception
    {
        const string message = "The Slot couldn't be created because this room " +
        	"already has two slots that day.";

        public SlotExceedRoomDailyLimitException() : base(message)
        {
        }
    }
}
