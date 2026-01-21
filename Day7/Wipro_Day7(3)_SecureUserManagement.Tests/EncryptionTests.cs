using Xunit;
using Wipro_Day7_2_SecureUserManagement.Security;

namespace Wipro_Day7_3_SecureUserManagement.Tests
{
    public class EncryptionTests
    {
        [Fact]
        public void Encrypt_Test()
        {
            Assert.Equal("x", AESEncryption.Encrypt("x"));
        }
    }
}
