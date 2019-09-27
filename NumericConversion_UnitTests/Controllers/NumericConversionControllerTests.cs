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

        //[TestMethod]
        //public void NumericConverterLanding_StateUnderTest_ExpectedBehavior1()
        //{
        //    // Arrange
        //    // var numericConversionController = this.CreateNumericConversionController();
        //    // NumberConversionModel model = null;

        //    // Act
        //    //var result = numericConversionController.NumericConverterLanding(
        //    //    model);

        //    // Assert
        //    Assert.Fail();
        //}

        [TestMethod]
        public void NumericConverter_NumberToWordsIsCorrect_ReturnsNumber()
        {
            // Arrange
            NumericConversionController numericConversionController = this.CreateNumericConversionController();

            NumberConversionModel num = new NumberConversionModel { number = 24.3 };
            string expectedResult = "Twenty Four  and 3/100 Dollars";
            // Act
            var result = numericConversionController.NumericConverter(num);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        //[TestMethod]
        //public void Error_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var numericConversionController = this.CreateNumericConversionController();

        //    // Act
        //    //var result = numericConversionController.Error();

        //    // Assert
        //    Assert.Fail();
        //}
    }
}
