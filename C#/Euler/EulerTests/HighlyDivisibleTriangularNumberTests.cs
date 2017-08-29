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
    public class HighlyDivisibleTriangularNumberTests
    {
        [TestMethod()]
        public void HighlyDivisibleTriangularNumber_Solution1Test()
        {
            Assert.AreEqual(28, new HighlyDivisibleTriangularNumber().Solution1(5));
            Assert.AreEqual(76576500, new HighlyDivisibleTriangularNumber().Solution1(500));
        }
    }
}