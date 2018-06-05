using System;
using SQLI.CodingDojo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQLI.CodingDojo.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Throws_ArgumentException_If_Param_is_0()
        {
            // Arrange - Autant de lignes de code que l'on veut
            // Act - 1 seule ligne
            FizzBuzz.CheckValue(0);
            // Assert - 1 ou 0 (cas particulier avec MSTEST)
        }
    }
}
