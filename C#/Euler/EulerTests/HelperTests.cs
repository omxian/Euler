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
        public void Helper_IsEvenTest()
        {
            Assert.IsTrue(Helper.IsEven(0));
            Assert.IsFalse(Helper.IsEven(1));
            Assert.IsFalse(Helper.IsEven(3));
            Assert.IsTrue(Helper.IsEven(4));
        }

        [TestMethod()]
        public void IsPrimeTest()
        {
            Assert.IsTrue(Helper.IsPrime(2));
            Assert.IsTrue(Helper.IsPrime(3));
            Assert.IsTrue(Helper.IsPrime(5));
            Assert.IsTrue(Helper.IsPrime(7));
            Assert.IsTrue(Helper.IsPrime(11));
            Assert.IsTrue(Helper.IsPrime(13));
            Assert.IsTrue(Helper.IsPrime(17));

            Assert.IsFalse(Helper.IsPrime(-2));
            Assert.IsFalse(Helper.IsPrime(0));
            Assert.IsFalse(Helper.IsPrime(1));
            Assert.IsFalse(Helper.IsPrime(4));
            Assert.IsFalse(Helper.IsPrime(22));
        }
    }
}