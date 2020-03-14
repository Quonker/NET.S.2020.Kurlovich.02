using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1Tests
{
    [TestClass]
    public class InsertNumberTests
    {
        [TestMethod]
        public void ResultTest()
        {
            Assert.AreEqual(15, Program.InsertNumber(15, 15, 0, 0), "test failed");
            Assert.AreEqual(9, Program.InsertNumber(8, 15, 0, 0), "test failed");
            Assert.AreEqual(120, Program.InsertNumber(8, 15, 3, 8), "test failed");
        }
    }
}
