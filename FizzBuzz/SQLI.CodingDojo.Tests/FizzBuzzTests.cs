﻿using System;
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

        [TestMethod]
        public void Returns_1_if_param_is_1()
        {
            // Arrange
            int param = 1;
            // Act
            int result = FizzBuzz.CheckValue(param);
            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Returns_2_if_param_is_2()
        {
            //Arrange
            int param = 2;
            // Act
            int result = FizzBuzz.CheckValue(param);
            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
