// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;
public partial class Program
{
    public static void Main (string[] args)
    {
        Wipro_Day3_1_.SavingsAccount savingsAcct = new Wipro_Day3_1_.SavingsAccount("Jyothi123", "346", 9.2m, 5.0m, "OGL");

        savingsAcct.Deposit(2500);
        decimal interest = savingsAcct.CalculateInterest();
        Console.WriteLine($" Interest for Saving Account :{interest} ");

        


    }
}