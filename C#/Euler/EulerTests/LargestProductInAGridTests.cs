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
    public class LargestProductInAGridTests
    {
        [TestMethod()]
        public void LargestProductInAGrid_Solution1Test()
        {
            Assert.AreEqual(70600674, new LargestProductInAGrid().Solution1(4));
        }
    }
}