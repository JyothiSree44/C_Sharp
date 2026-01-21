using Wipro_Day7_2_SecureUserManagement.Services;

class Program
{
    static void Main()
    {
        AuthServices auth = new AuthServices();
        auth.Register("user", "pass", "mail");

        System.Console.WriteLine(auth.Login("user", "pass"));
    }
}
