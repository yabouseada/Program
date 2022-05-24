namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result = UniqueApp.Unique.hasAllUniqueCharacters("abcd");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result = UniqueApp.Unique.hasAllUniqueCharacters("abcd");
            Assert.AreEqual(false, result);
        }
    }
}