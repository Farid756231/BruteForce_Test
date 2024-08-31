using BruteForce_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_Tests
{
    public class AccountSecurityTests
    {
        [Fact]
        public void RecordFailedAttempt_ShouldBlockAccountAfterMaxAttempts()
        {
            // Arrange
            var security = new AccountSecurity();

            // Act
            security.RecordFailedAttempt();
            security.RecordFailedAttempt();
            security.RecordFailedAttempt();

            // Assert
            Assert.True(security.IsBlocked);
        }
    }
}
