using ConsoleProject;

namespace ConsoleProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hello hello = new Hello();
            var expected = "Hello World";
            var actual = hello.GetName();
            Assert.AreEqual(expected, actual);
        }
    }
}