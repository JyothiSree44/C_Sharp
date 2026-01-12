

public partial class Program
{
    public static void Main(string[] args)
    {

        Wipro_Day3_2__BankAudit.CorporateAccount corpAcct = new Wipro_Day3_2__BankAudit.CorporateAccount("Chinni890", "345", 45690m, 8.98m, "MGR");

        corpAcct.Deposit(45690);
        corpAcct.ApplyCorporateInterest();
        Console.WriteLine("Corporate Account interest applied successfully");

    }
}