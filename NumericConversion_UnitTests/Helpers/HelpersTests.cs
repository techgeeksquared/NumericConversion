using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion.Helpers;
using System;

namespace NumericConversion_UnitTests.Helpers
{
    [TestClass]
    public class HelpersTests
    {
        [TestInitialize]
        public void TestInitialize()
        {

        }

        private ConversionHelpers CreateHelpers()
        {
            return new ConversionHelpers();
        }

        [TestMethod]
        public void isCurrencyType_WhenTypeIsCents_ReturnsCentsString()
        {
            // Arrange
            int typeTest = 0;
            string typeExpected = "Cents";
            // Act
            var result = ConversionHelpers.isCurrencyType(typeTest);

            // Assert
            Assert.AreEqual(typeExpected, result);
        }

        [TestMethod]
        public void ConvertWholeNumber_EmptyStringTest_ReturnsEmptyString()
        {
            // Arrange
            var helpers = this.CreateHelpers();
            string Number = "";
            string stringExpected = "";
            // Act
            var result = ConversionHelpers.ConvertWholeNumber(Number);

            // Assert
            Assert.AreEqual(stringExpected, result);
        }

        [TestMethod]
        public void ConvertWholeNumber_PositiveIntNumberStringTest_ReturnsNumericIntString()
        {
            // Arrange
            var helpers = this.CreateHelpers();
            string Number = "101.25";
            string stringExpected = "One Hundred One Thousand Hundred Twenty Five";
            // Act
            var result = ConversionHelpers.ConvertWholeNumber(Number);

            // Assert
            Assert.AreEqual(stringExpected, result);
        }
    }
}
