using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Cancel not booked slot exception.
    /// Indicate rule: can't cancel a booking if the slot haven't been booked yet 
    /// </summary>
    public class CancelNotBookedSlotException : Exception
    {
        const string message = "Cancel failed because no student booked this slot.";

        public CancelNotBookedSlotException() : base(message)
        {
        }
    }
}
