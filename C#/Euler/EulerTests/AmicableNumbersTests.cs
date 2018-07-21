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
    public class AmicableNumbersTests
    {
        [TestMethod()]
        public void CountAmicableNumbersSumTest()
        {
            Assert.AreEqual(504, new AmicableNumbers().CountAmicableNumbersSum(300));
            Assert.AreEqual(31626, new AmicableNumbers().CountAmicableNumbersSum(10000));
            Assert.AreEqual(53226, new AmicableNumbers().CountAmicableNumbersSum(11000));
        }
    }
}