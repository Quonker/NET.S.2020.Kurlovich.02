using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace Task4Tests
{
    [TestClass]
    public class FilterDigitTests
    {
        [TestMethod]
        public void ResultTest()
        {
            CollectionAssert.AreEqual(new int[] { 7, 70, 17 }, Program.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7), "test failed");
            CollectionAssert.AreEqual(new int[] { 25, 52, 82 }, Program.FilterDigit(new int[] { 17, 25, 52, 30, 31, 82, 140, 144 }, 2), "test failed");
            CollectionAssert.AreEqual(new int[] { 8001, 10 }, Program.FilterDigit(new int[] { 9,8001,3,11,234,758, 10 }, 0), "test failed");
            CollectionAssert.AreEqual(new int[] { }, Program.FilterDigit(new int[] { 1,2,3 }, 8), "test failed");

        }
    }
}
