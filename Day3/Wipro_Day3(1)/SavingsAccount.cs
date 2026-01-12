using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Wipro_Day3_1_
{
    public class SavingsAccount : BankAccount

    {
        public SavingsAccount(string accNumber, string pin, decimal initialBalance, decimal rate, string branchCode)
            : base(accNumber, pin, initialBalance, rate, branchCode)
        {
        }
        public decimal CalculateInterest()
        {
            return balance * (decimal)interestRate / 100;
        }
    }
}
