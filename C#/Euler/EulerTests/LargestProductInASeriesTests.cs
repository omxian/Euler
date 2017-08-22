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
    public class LargestProductInASeriesTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(5832, new LargestProductInASeries().Solution1(4));
            Assert.AreEqual(23514624000, new LargestProductInASeries().Solution1(13));
        }
    }
}