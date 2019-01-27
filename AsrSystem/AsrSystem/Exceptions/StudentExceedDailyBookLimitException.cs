using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Student exceed daily book limit exception.
    /// Indicate business rule: A student can only make 1 booking per day.
    /// </summary>
    public class StudentExceedDailyBookLimitException : Exception
    {
        const string message = "Can't book because a student can only make 1 " +
        	"booking per day.";

        public StudentExceedDailyBookLimitException() : base(message)
        {
        }
    }
}
