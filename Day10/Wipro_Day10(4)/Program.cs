using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Create cryptographically secure random bytes
        byte[] key = new byte[32]; // 256-bit key

        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(key);
        }

        // Convert to Base64 string
        string secureKey = Convert.ToBase64String(key);

        Console.WriteLine("Generated New Key: " + secureKey);
    }
}