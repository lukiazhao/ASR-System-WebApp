using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Slot key already exist exception.
    /// Indicate rule: can't create a slot has same starttime and room with an
    /// existing slot.
    /// </summary>
    public class SlotKeyAlreadyExistException : Exception
    {
        const string message = "The Slot couldn't be created because it already exists.";

        public SlotKeyAlreadyExistException() : base(message)
        {
        }
    }
}
