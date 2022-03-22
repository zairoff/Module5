using System;

namespace Task3.Exceptions
{
    [Serializable]
    public class DuplicateUserException : Exception
    {
        public DuplicateUserException()
        {
        }

        public DuplicateUserException(string message) : base(message)
        {
        }
    }
}
