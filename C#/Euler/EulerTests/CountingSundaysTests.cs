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
    public class CountingSundaysTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            Assert.AreEqual(171,new CountingSundays().Solution());
        }
    }
}