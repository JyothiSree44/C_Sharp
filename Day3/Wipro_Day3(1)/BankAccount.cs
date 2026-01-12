public class BankAccount
{
    private string accountPIN;
    public string AccountNumber { get; private set; }
    protected internal decimal interestRate;
    protected internal string bankBranchCode;
    protected decimal balance;

    public BankAccount(string accNumber, string pin, decimal initialBalance, decimal rate, string branchCode)
    {
        AccountNumber = accNumber;
        accountPIN = pin;
        balance = initialBalance;
        interestRate = rate;
        bankBranchCode = branchCode;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
}
