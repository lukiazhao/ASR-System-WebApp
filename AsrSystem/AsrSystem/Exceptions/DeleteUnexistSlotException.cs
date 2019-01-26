using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Delete unexist slot exception.
    /// Indicate rule: Can't delete a slot that can't found in model and database
    /// </summary>
    public class DeleteUnexistSlotException : Exception
    {
        const string message = "The Slot can not be deleted because it doesn't exist.";

        public DeleteUnexistSlotException() : base(message)
        {
        }
    }
}
