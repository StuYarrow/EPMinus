namespace EPPlusTest.FormulaParsing
{
    [TestClass]
    public class ParsingContextTests
    {
        [TestMethod]
        public void ConfigurationShouldBeSetByFactoryMethod()
        {
            var context = ParsingContext.Create();
            Assert.IsNotNull(context.Configuration);
        }

        [TestMethod]
        public void ScopesShouldBeSetByFactoryMethod()
        {
            var context = ParsingContext.Create();
            Assert.IsNotNull(context.Scopes);
        }
    }
}
