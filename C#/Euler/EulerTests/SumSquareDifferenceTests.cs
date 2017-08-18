using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Tests
{
    [TestClass()]
    public class SumSquareDifferenceTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(2640, new SumSquareDifference().Solution1(10));
            Assert.AreEqual(25164150, new SumSquareDifference().Solution1(100));
        }

        [TestMethod()]
        public void Solution2Test()
        {
            Assert.AreEqual(2640, new SumSquareDifference().Solution2(10));
            Assert.AreEqual(25164150, new SumSquareDifference().Solution2(100));
        }
    }
}