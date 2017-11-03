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
    public class PowerDigitSumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            Assert.AreEqual(26, new PowerDigitSum().Solution(15));
            Assert.AreEqual(1366, new PowerDigitSum().Solution(1000));
        }
    }
}