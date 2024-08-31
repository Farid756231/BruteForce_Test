using BruteForce_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_Tests
{
    public class TwoFactorAuthenticationTests
    {
        [Fact]
        public void VerifyCode_ShouldReturnTrueForCorrectCode()
        {
            // Arrange
            var twoFA = new TwoFactorAuthentication("JBSWY3DPEHPK3PXP");
            string code = twoFA.GenerateCode();

            // Act
            bool result = twoFA.VerifyCode(code);

            // Assert
            Assert.True(result);
        }
    }
}
