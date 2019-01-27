using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slot time invalid exception.
    /// Indicate business rule: The slots must be booked between the school working hours of 9am to 2pm and
    /// will always be booked at the start of the hour, e.g., 10:00am, 1:00pm, etc...
    /// </summary>
    public class SlotTimeInvalidException : Exception
    {
        const string message = "The Slot couldn't be created because its start time " +
        	"is invalid.";

        public SlotTimeInvalidException() : base(message)
        {
        }
    }
}
