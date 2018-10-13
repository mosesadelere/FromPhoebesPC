using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(5, 90);
            Assert.AreEqual(res, 95);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(50, 9);
            Assert.AreEqual(res, 41);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(50, 9);
            Assert.AreEqual(res, 450);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Divide(95, 19);
            Assert.AreEqual(res, 5);
        }
    }
}
