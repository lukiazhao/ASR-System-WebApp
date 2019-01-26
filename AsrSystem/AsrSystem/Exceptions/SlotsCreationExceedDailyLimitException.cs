using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slots creation exceed daily limit exception.
    /// Indicate business rule: A staff member can book a maximum of 4 slots per day.
    /// </summary>
    public class SlotsCreationExceedDailyLimitException : Exception
    {
        const string message = "The Slot couldn't be created because a staff " +
        	"member can only book a maximum of 4 slots per day";

        public SlotsCreationExceedDailyLimitException() : base(message)
        {
        }
    }
}
