using System;

namespace Wipro_day5_2_
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
