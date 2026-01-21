using System.Security.Cryptography;
using System.Text;

namespace Wipro_Day12_SecureUserApp.Services
{
    public class EncryptionService
    {
        private readonly byte[] key;
        private readonly byte[] iv;

        public EncryptionService()
        {
            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;
            }
        }

        public byte[] Encrypt(string data)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] input = Encoding.UTF8.GetBytes(data);
                    return encryptor.TransformFinalBlock(input, 0, input.Length);
                }
            }
        }

        public string Decrypt(byte[] encryptedData)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] output =
                        decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                    return Encoding.UTF8.GetString(output);
                }
            }
        }
    }
}
