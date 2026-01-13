using System;

namespace Wipro_Day5_1_
{
    // Custom exception
    public class DailyLimitExceeded : Exception
    {
        public DailyLimitExceeded(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        private decimal dailyLimit = 1000;
        private decimal totalTransactions = 0;

        // Property to get remaining balance
        public decimal RemainingBalance
        {
            get { return dailyLimit - totalTransactions; }
        }

        public void MakeTransaction(decimal amount)
        {
            if (totalTransactions + amount > dailyLimit)
            {
                throw new DailyLimitExceeded("Transaction exceeded daily limit.");
            }

            totalTransactions += amount;
            Console.WriteLine("Transaction successful.");
            Console.WriteLine("Remaining balance: " + RemainingBalance);
        }
    }
}
