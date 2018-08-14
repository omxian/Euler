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
    public class _1000_digitFibonacciNumberTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Assert.AreEqual(4782, new _1000_digitFibonacciNumber().Solve());
        }
    }
}