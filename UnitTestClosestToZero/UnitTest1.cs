using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestClosestToZero
{
    [TestClass]
    public class UnitTest1
    {
        private readonly int[] testIntsNeg = { 24, -15, -35 };
        private readonly int[] testIntsPos = { 24, -15, 15, -35 };
        private const int sol1 = -15;
        private const int sol2 = 15;

        [TestMethod]
        public void TestStartMethod1()
        {
            var result = ClosestToZero.Program.ClosestToZeroInArray(testIntsNeg);
            Assert.AreEqual(result, sol1);
        }

        [TestMethod]
        public void TestStartMethod2()
        {
            var result = ClosestToZero.Program.ClosestToZeroInArray(testIntsPos);
            Assert.AreEqual(result, sol2);
        }
    }
}
