using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace Task5Tests
{
    [TestClass]
    public class FindNthRootTests
    {
        [TestMethod]
        public void ResultTest()
        {
            Assert.AreEqual(1, Program.FindNthRoot(1, 5, 0.0001), 0.0001, "1 test failed");
            Assert.AreEqual(2, Program.FindNthRoot(8, 3, 0.0001), 0.0001, "2 test failed");
            Assert.AreEqual(0.1, Program.FindNthRoot(0.001, 3, 0.0001), 0.0001, "3 test failed");
            Assert.AreEqual(0.45, Program.FindNthRoot(0.04100625, 4, 0.0001), 0.0001, "4 test failed");
            Assert.AreEqual(0.6, Program.FindNthRoot(0.0279936, 7, 0.0001), 0.0001, "5 test failed");
            Assert.AreEqual(2, Program.FindNthRoot(8, 3, 0.00001), 0.0001, "6 test failed");
            Assert.AreEqual(0.3, Program.FindNthRoot(0.0081, 4, 0.01), 0.1, "7 test failed");
            Assert.AreEqual(-0.2, Program.FindNthRoot(-0.008, 3, 0.01), 0.1, "8 test failed");
            // i test epx = 0.0000001
            // cuz 0.0000001 = 3sec
            //     0.00000001 > 10min
            // but, if I improve the algorithm,
            // it will not be Newton’s method
            Assert.AreEqual(0.545, Program.FindNthRoot(0.004241979, 9, 0.0000001), 0.0000001, "9 test failed");

            // Argument Out Of Range Exception
            //Assert.AreEqual(0, Program.FindNthRoot(8, 15, -7), -7, "10 test failed");
            //Assert.AreEqual(0, Program.FindNthRoot(8, 15, -0.6), -0.6, "11 test failed");

        }
    }
}
