using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slot already booked exception.
    /// Indicate business rule: A slot can have a maximum of 1 student booked into it.
    /// </summary>
    public class SlotAlreadyBookedException : Exception
    {
        const string message = "Can't book this slot because it is already booked.";

        public SlotAlreadyBookedException() : base(message)
        {
        }
    }
}
