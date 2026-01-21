using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wipro_Day12_SecureUserApp.Services;

namespace Wipro_Day12_SecureUserApp.Tests
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void Register_And_Login_Should_Succeed()
        {
            // Arrange
            AuthService auth = new AuthService();

            // Act
            auth.Register("testuser", "1234", "test@mail.com");
            bool result = auth.Login("testuser", "1234");

            // Assert
            Assert.IsTrue(result);
        }
    }
}
