using System;
using Wipro_Day12_SecureUserApp.Services;

class Program
{
    static void Main()
    {
        AuthService authService = new AuthService();
        EncryptionService encryptionService = new EncryptionService();

        try
        {
            authService.Register("chinni", "1234", "chinni@gmail.com");

            bool result = authService.Login("chinni", "1234");
            Console.WriteLine("Login Successful: " + result);

            string secret = "Confidential Data";
            byte[] encrypted = encryptionService.Encrypt(secret);
            string decrypted = encryptionService.Decrypt(encrypted);

            Console.WriteLine("Decrypted Data: " + decrypted);
        }
        catch
        {
            Console.WriteLine("Error occurred. Check log file.");
        }
    }
}
