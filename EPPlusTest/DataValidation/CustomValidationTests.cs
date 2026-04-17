using System;

namespace EPPlusTest.DataValidation
{
    [TestClass]
    public class CustomValidationTests : ValidationTestBase
    {
        [TestInitialize]
        public void Setup()
        {
            SetupTestData();
        }

        [TestCleanup]
        public void Cleanup()
        {
            CleanupTestData();
        }

        [TestMethod]
        public void CustomValidation_FormulaIsSet()
        {
            // Act
            var validation = _sheet.DataValidations.AddCustomValidation("A1");

            // Assert
            Assert.IsNotNull(validation.Formula);
        }

        [TestMethod]
        public void CustomValidation_ShouldThrowExceptionIfFormulaIsTooLong()
        {
            // Arrange
            var sb = new StringBuilder();
            for (var x = 0; x < 257; x++) sb.Append("x");
            
            // Act => Assert
            var validation = _sheet.DataValidations.AddCustomValidation("A1");
            Assert.Throws<InvalidOperationException>(() => validation.Formula.ExcelFormula = sb.ToString());
        }
    }
}
