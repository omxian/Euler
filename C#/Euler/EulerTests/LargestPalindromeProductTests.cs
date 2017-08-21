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
    public class LargestPalindromeProductTests
    {
        [TestMethod()]
        public void LargestPalindromeProduct_Solution1Test()
        {
            Assert.AreEqual(906609, new LargestPalindromeProduct().Solution1());
        }

        [TestMethod()]
        public void LargestPalindromeProduct_Solution2Test()
        {
            Assert.AreEqual(9, new LargestPalindromeProduct().Solution2(1));
            Assert.AreEqual(9009, new LargestPalindromeProduct().Solution2(2));
            Assert.AreEqual(906609, new LargestPalindromeProduct().Solution2(3));
        }
    }
}