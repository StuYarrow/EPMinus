namespace EPPlusTest.Excel.Functions
{
    [TestClass]
    public class ArgumentParsersTests
    {
        [TestMethod]
        public void ShouldReturnSameInstanceOfIntParserWhenCalledTwice()
        {
            var parsers = new ArgumentParsers();
            var parser1 = parsers.GetParser(DataType.Integer);
            var parser2 = parsers.GetParser(DataType.Integer);
            Assert.AreEqual(parser1, parser2);
        }
    }
}
