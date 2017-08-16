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
        public void Solution1Test()
        {
            Assert.AreEqual(232792560, new SmallestMultiple().Solution1(20));
            Assert.AreEqual(2520, new SmallestMultiple().Solution1(10));
        }
    }
}