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
    public class _10001stPrimeTests
    {
        [TestMethod()]
        public void _10001stPrimeTests_Solution1Test()
        {
            Assert.AreEqual(2, new _10001stPrime().Solution1(1));
            Assert.AreEqual(3, new _10001stPrime().Solution1(2));
            Assert.AreEqual(5, new _10001stPrime().Solution1(3));
            Assert.AreEqual(7, new _10001stPrime().Solution1(4));
            Assert.AreEqual(11, new _10001stPrime().Solution1(5));
            Assert.AreEqual(13, new _10001stPrime().Solution1(6));
            Assert.AreEqual(104743, new _10001stPrime().Solution1(10001));
        }
    }
}