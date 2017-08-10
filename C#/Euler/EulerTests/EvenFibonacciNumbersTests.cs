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
    public class EvenFibonacciNumbersTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(4613732, new EvenFibonacciNumbers().Solution1());
        }

        [TestMethod()]
        public void Solution2Test()
        {
            Assert.AreEqual(4613732, new EvenFibonacciNumbers().Solution2());
        }
    }
}