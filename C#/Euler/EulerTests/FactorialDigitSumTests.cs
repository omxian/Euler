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
    public class FactorialDigitSumTests
    {
        [TestMethod()]
        public void CountTest()
        {
            Assert.AreEqual(27, new FactorialDigitSum().Count(10));
            Assert.AreEqual(648, new FactorialDigitSum().Count(100));
        }
    }
}