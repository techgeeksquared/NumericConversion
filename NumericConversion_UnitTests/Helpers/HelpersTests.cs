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

        private Helpers CreateHelpers()
        {
            return new Helpers();
        }

        [TestMethod]
        public void isCurrencyType_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var helpers = this.CreateHelpers();
            int type = 0;

            // Act
            var result = helpers.isCurrencyType(
                type);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void ConvertWholeNumber_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var helpers = this.CreateHelpers();
            String Number = null;

            // Act
            var result = helpers.ConvertWholeNumber(
                Number);

            // Assert
            Assert.Fail();
        }
    }
}
