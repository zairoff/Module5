using System;

namespace Task3.Exceptions
{
    public class DuplicateUserException : Exception
    {
        public DuplicateUserException(string message) : base(message)
        {
        }
    }
}
