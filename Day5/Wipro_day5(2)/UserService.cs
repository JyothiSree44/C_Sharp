using System;
using Wipro_day5_2_.CustomExceptions;

namespace Wipro_day5_2_
{
    public class UserService
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("User must be 18 years or older.");
            }

            Console.WriteLine("User age validated.");
        }
    }
}
