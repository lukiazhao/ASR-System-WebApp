using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Invalid room exception.
    /// Indicate rule: Can't process any room related feature if the room isn't
    /// exist in database and model.
    /// </summary>
    public class InvalidRoomException : Exception
    {
        private String ErrorMessage;

        public InvalidRoomException(string errorMessage) : base(errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
