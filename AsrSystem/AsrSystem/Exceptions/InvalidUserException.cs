using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// The error message.
    /// Indicate rule: Can't process any user related feature if the user isn't
    /// exist in database and model.
    /// </summary>
    public class InvalidUserException : Exception
    {
        public String ErrorMessage;

        public InvalidUserException(string errorMessage) : base(errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
