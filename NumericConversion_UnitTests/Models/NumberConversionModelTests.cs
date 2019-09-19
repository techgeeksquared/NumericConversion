using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion.Models;
using System;

namespace NumericConversion_UnitTests.Models
{
    [TestClass]
    public class NumberConversionModelTests
    {
        [TestMethod]
        public void DecimalToWords_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var numberConversionModel = new NumberConversionModel();
            double number = 0;

            // Act
            var result = numberConversionModel.DecimalToWords(
                number);

            // Assert
            Assert.Fail();
        }
    }
}
