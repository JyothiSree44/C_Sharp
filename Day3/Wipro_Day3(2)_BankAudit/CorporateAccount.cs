using System;
using Wipro_Day3_1_;

namespace Wipro_Day3_2__BankAudit
{
    public class CorporateAccount : BankAccount
    {
        public CorporateAccount(
            string accNumber,
            string pin,
            decimal initialBalance,
            decimal rate,
            string branchCode
        ) : base(accNumber, pin, initialBalance, rate, branchCode)
        {
        }

        public void ApplyCorporateInterest()
        {
            decimal interest = balance * interestRate / 100;
            balance += interest;
            Console.WriteLine($"Corporate Interest Added: {interest:C}. New Balance: {balance:C}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Interest Rate: {interestRate}%");
            Console.WriteLine($"Bank Branch Code: {bankBranchCode}");
            Console.WriteLine($"Balance: {balance:C}");
        }
    }
}
