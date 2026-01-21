using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wipro_Day12_SecureUserApp.Services;

namespace Wipro_Day12_SecureUserApp.Tests
{
    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void Encrypt_And_Decrypt_Should_Return_Original_Data()
        {
            EncryptionService service = new EncryptionService();
            string original = "SensitiveData";

            byte[] encrypted = service.Encrypt(original);
            string decrypted = service.Decrypt(encrypted);

            Assert.AreEqual(original, decrypted);
        }
    }
}
