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
    public class LargestPrimeFactorTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(29, new LargestPrimeFactor().Solution1(13195));
            Assert.AreEqual(6857, new LargestPrimeFactor().Solution1(600851475143));
        }
    }
}