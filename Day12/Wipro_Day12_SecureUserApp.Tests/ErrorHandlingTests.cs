using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wipro_Day12_SecureUserApp.Services;

namespace Wipro_Day12_SecureUserApp.Tests
{
    [TestClass]
    public class ErrorHandlingTests
    {
        [TestMethod]
        public void Login_Should_Fail_For_Invalid_User()
        {
            AuthService auth = new AuthService();
            bool result = auth.Login("wrongUser", "123");

            Assert.IsFalse(result);
        }
    }
}
