using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion.Controllers;
using Microsoft.AspNetCore.Mvc;
using NumericConversion.Models;
using System;

namespace NumericConversion_UnitTests.Controllers
{
    [TestClass]
    public class NumericConversionControllerTests
    {
        [TestInitialize]
        public void TestInitialize()
        {

        }

        private NumericConversionController CreateNumericConversionController()
        {
            return new NumericConversionController();
        }
       
        [TestMethod]
        public void NumericConverter_NumberToWordsIsCorrect_ReturnsNumber()
        {
            // Arrange
            NumericConversionController numericConversionController = this.CreateNumericConversionController();
            string expectedResult = "Twenty Four  and 3/100 Dollars";
            double enteredResult = 24.3;
            NumberConversionModel num = new NumberConversionModel { number = enteredResult };
           
            // Act
            var result = numericConversionController.NumericConverter(num);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
    }
}
