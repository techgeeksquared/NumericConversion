using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion.Models;
using System;

namespace NumericConversion_UnitTests.Models
{
    [TestClass]
    public class NumberConversionModelTests
    {
        [TestMethod]
        public void DecimalToWords_NegativeNumberTest_ReturnTwoSpaces()
        {
            // Arrange
            var numberConversionModel = new NumberConversionModel();
            double numberTest = -11;
            string wordStringResult = "  ";
            // Act
            var result = numberConversionModel.DecimalToWords(numberTest);

            // Assert
            Assert.AreEqual(wordStringResult, result);
        }

        [TestMethod]
        public void DecimalToWords_PositiveDoubleTest_ReturnWordString()
        {
            // Arrange
            var numberConversionModel = new NumberConversionModel();
            double numberTest = 1000123.011;
            string wordStringResult = "One Million and Thousand One Hundred Twenty Three  and 011/100 Dollars";
            // Act
            var result = numberConversionModel.DecimalToWords(numberTest);

            // Assert
            Assert.AreEqual(wordStringResult, result);
        }
    }
}
