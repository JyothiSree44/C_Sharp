using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day4_1_
{
    using System;

    // STEP 1: Static configuration class (global settings)
    class PlatformConfig
    {
        public static string PlatformName = "LearnSphere";
        public static int TotalRegisteredUsers = 0;
        public static int MaxLoginAttempts = 3;
        public static double GlobalDiscountRate = 10.0;
    }

    // STEP 2: Instance-based User class
    class User
    {
        public int UserId;
        public string UserName;
        public string Email;

        // NEW: stores login attempt count per user
        private int loginAttemptCount = 0;

        public User(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;

            // Increment shared static counter
            PlatformConfig.TotalRegisteredUsers++;
        }

        public void DisplayUserDetails()
        {
            Console.WriteLine("User ID: " + UserId);
            Console.WriteLine("User Name: " + UserName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Max Login Attempts Allowed: " + PlatformConfig.MaxLoginAttempts);
            Console.WriteLine("Global Discount Rate: " + PlatformConfig.GlobalDiscountRate + "%");
        }

        // NEW: Login attempt tracking
        public void Login()
        {
            if (loginAttemptCount < PlatformConfig.MaxLoginAttempts)
            {
                loginAttemptCount++;

                Console.WriteLine(
                    $"Login Attempt: {loginAttemptCount} of {PlatformConfig.MaxLoginAttempts}");
            }
            else
            {
                Console.WriteLine("Account locked. Maximum login attempts exceeded.");
            }
        }
    }

    // STEP 3: Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Access static properties without creating object
            Console.WriteLine("Platform Name: " + PlatformConfig.PlatformName);
            Console.WriteLine();

            // Create user object
            User user1 = new User(101, "Jyothi", "jyothi@gmail.com");

            // Display user details
            user1.DisplayUserDetails();
            Console.WriteLine();

            // Login attempts
            user1.Login(); // 1 of 3
            user1.Login(); // 2 of 3
            user1.Login(); // 3 of 3
            user1.Login(); // locked

            Console.WriteLine();
            Console.WriteLine("Total Registered Users: " + PlatformConfig.TotalRegisteredUsers);
        }
    }

}

