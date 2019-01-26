using System;
namespace ASR_System.Exceptions
{
    /// <summary>
    /// Invalid user input exception.
    /// Indicate rule: user option choice in menu should follow a certain format
    /// </summary>
    public class InvalidUserInputException : Exception
    {
        private const string message = "Invalid Input";
        public InvalidUserInputException() : base(message)
        {
        }
    }
}
