using BruteForce_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce_Tests
{
    public class PasswordBruteForcerTests
    {
        [Fact]
        public void NextGuess_ShouldGenerateCorrectInitialGuess()
        {
            // Arrange
            var bruteForcer = new PasswordBruteForcer(5);

            // Act
            string guess = bruteForcer.NextGuess();

            // Assert
            Assert.Equal("aaaaa", guess); // Note: the expected value should be "aaaaa"
        }
    }
}
