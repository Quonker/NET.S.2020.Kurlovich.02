using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class FindNumberTests
    {
        [TestMethod]
        public void ResultTest()
        {
            Assert.AreEqual(21, Program.FindNextBiggerNumber(12), "test failed");
            Assert.AreEqual(531, Program.FindNextBiggerNumber(513), "test failed");
            Assert.AreEqual(2071, Program.FindNextBiggerNumber(2017), "test failed");
            Assert.AreEqual(441, Program.FindNextBiggerNumber(414), "test failed");
            Assert.AreEqual(414, Program.FindNextBiggerNumber(144), "test failed");
            Assert.AreEqual(1241233, Program.FindNextBiggerNumber(1234321), "test failed");
            Assert.AreEqual(1234162, Program.FindNextBiggerNumber(1234126), "test failed");
            Assert.AreEqual(3462345, Program.FindNextBiggerNumber(3456432), "test failed");
            Assert.AreEqual(-1, Program.FindNextBiggerNumber(10), "test failed");
            Assert.AreEqual(-1, Program.FindNextBiggerNumber(20), "test failed");
            Assert.AreEqual(-1, Program.FindNextBiggerNumber(-132), "test failed");
        }
    }
}
