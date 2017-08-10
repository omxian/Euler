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
    public class HelperTests
    {
        [TestMethod()]
        public void IsEvenTest()
        {
            Assert.IsTrue(Helper.IsEven(0));
            Assert.IsFalse(Helper.IsEven(1));
            Assert.IsFalse(Helper.IsEven(3));
            Assert.IsTrue(Helper.IsEven(4));
        }
    }
}