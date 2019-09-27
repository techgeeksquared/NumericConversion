using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion.Factories;
using System;

namespace NumericConversion_UnitTests.Factories
{
    [TestClass]
    public class ConversionFactoryTests
    {


        [TestInitialize]
        public void TestInitialize()
        {

        }

        private ConversionFactory CreateFactory()
        {
            return new ConversionFactory();
        }

        //[TestMethod]
        //public void ConvertToText_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var factory = this.CreateFactory();
        //    String inputNumber = null;

        //    // Act
        //    //var result = factory.ConvertToText( inputNumber);

        //    // Assert
        //    Assert.Fail();
        //}
    }
}
