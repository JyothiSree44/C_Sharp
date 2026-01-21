using Xunit;
using Wipro_Day7_2_SecureUserManagement.Services;

namespace Wipro_Day7_3_SecureUserManagement.Tests
{
    public class AuthTests
    {
        [Fact]
        public void Login_Test()
        {
            AuthServices auth = new AuthServices();
            Assert.True(auth.Login("a", "b"));
        }
    }
}
