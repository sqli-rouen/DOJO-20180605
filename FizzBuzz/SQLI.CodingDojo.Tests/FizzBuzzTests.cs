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

        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [TestMethod]
        public void Returns_value_if_param_is_1_or_2(int param,string expected)
        {
            // Arrange
            // Act
            string result = FizzBuzz.CheckValue(param);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Returns_Fizz_if_param_is_3()
        {
            //Arrange
            int param = 3;
            // Act
            string result = FizzBuzz.CheckValue(param);
            // Assert
            Assert.AreEqual("Fizz", result);
        }
        
    }
}
