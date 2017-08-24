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
    public class SummationOfPrimesTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(17, new SummationOfPrimes().Solution1(10));
            Assert.AreEqual(142913828922, new SummationOfPrimes().Solution1(2000000));
        }
    }
}