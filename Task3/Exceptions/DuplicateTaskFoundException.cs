using System;

namespace Task3.Exceptions
{
    public class DuplicateTaskFoundException : Exception
    {
        public DuplicateTaskFoundException(string message) : base(message)
        {
        }
    }
}
