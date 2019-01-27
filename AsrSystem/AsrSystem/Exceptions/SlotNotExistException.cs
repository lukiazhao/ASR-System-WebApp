using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slot Not Exist Exception.
    /// Indicate rule: Can't process any slot related feature if the slot isn't
    /// exist in database and model.
    /// </summary>
    public class SlotNotExistException : Exception
    {
        const string message = "Slot doesn't exist.";

        public SlotNotExistException() : base(message)
        {
        }
    }
}
