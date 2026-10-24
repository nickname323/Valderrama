using System;

namespace LabStream
{
    public class InvalidBirthdayException : Exception
    {
        public InvalidBirthdayException()
            : base("Birthday cannot be a future date.")
        {
        }
    }
}
