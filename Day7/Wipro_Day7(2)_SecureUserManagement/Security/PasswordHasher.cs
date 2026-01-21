using System.Security.Cryptography;
using System.Text;

namespace Wipro_Day7_2_SecureUserManagement.Security
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string hash = HashPassword(password);
            return hash == hashedPassword;
        }
    }
}
