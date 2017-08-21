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
    public class SmallestMultipleTests
    {
        [TestMethod()]
        public void SmallestMultiple_Solution1Test()
        {
            Assert.AreEqual(232792560, new SmallestMultiple().Solution1(20));
            Assert.AreEqual(2520, new SmallestMultiple().Solution1(10));
            Assert.AreEqual(60, new SmallestMultiple().Solution1(5));
        }

        [TestMethod()]
        public void SmallestMultiple_Solution2Test()
        {
            Assert.AreEqual(232792560, new SmallestMultiple().Solution2(20));
            Assert.AreEqual(2520, new SmallestMultiple().Solution2(10));
            Assert.AreEqual(60, new SmallestMultiple().Solution2(5));
        }
    }
}