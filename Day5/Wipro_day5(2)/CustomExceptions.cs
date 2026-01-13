using System;

namespace Wipro_day5_2_.CustomExceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message) { }
    }
}
