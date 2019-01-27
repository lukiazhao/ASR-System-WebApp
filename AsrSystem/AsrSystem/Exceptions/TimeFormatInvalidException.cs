using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Time format invalid exception.
    /// Check time format from user input and whether it is a valid date
    /// </summary>
    public class TimeFormatInvalidException : Exception
    {
        const string message = "Invalid time format.";

        public TimeFormatInvalidException() : base(message)
        {
        }
    }
}
