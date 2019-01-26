using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Delete already booked slot exception.
    /// Indicate business rule: A staff member cannot delete a 
    /// slot once it has been booked by a student.
    /// </summary>
    public class DeleteAlreadyBookedSlotException : Exception
    {
        const string message = "The Slot can not be deleted because it is booked.";

        public DeleteAlreadyBookedSlotException() : base(message)
        {
        }
    }
}
