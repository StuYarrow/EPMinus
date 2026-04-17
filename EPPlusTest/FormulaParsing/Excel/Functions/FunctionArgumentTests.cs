using OfficeOpenXml.FormulaParsing.Excel;

namespace EPPlusTest.Excel.Functions
{
    [TestClass]
    public class FunctionArgumentTests
    {
        [TestMethod]
        public void ShouldSetExcelState()
        {
            var arg = new FunctionArgument(2);
            arg.SetExcelStateFlag(ExcelCellState.HiddenCell);
            Assert.IsTrue(arg.ExcelStateFlagIsSet(ExcelCellState.HiddenCell));
        }

        [TestMethod]
        public void ExcelStateFlagIsSetShouldReturnFalseWhenNotSet()
        {
            var arg = new FunctionArgument(2);
            Assert.IsFalse(arg.ExcelStateFlagIsSet(ExcelCellState.HiddenCell));
        }
    }
}
