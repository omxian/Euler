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
    public class NumberLetterCountsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            Assert.AreEqual(19, new NumberLetterCounts().Solution(5));
            Assert.AreEqual(36, new NumberLetterCounts().Solution(9));
            Assert.AreEqual(70+36, new NumberLetterCounts().Solution(19));
            Assert.AreEqual(70 + 36 + 748, new NumberLetterCounts().Solution(99));
            Assert.AreEqual(70 + 36 + 748 + 10, new NumberLetterCounts().Solution(100));
            Assert.AreEqual(21113, new NumberLetterCounts().Solution(999));
            Assert.AreEqual(21124, new NumberLetterCounts().Solution(1000));
        }

        [TestMethod()]
        public void CountTest()
        {
            Assert.AreEqual(23, new NumberLetterCounts().Count(342));
            Assert.AreEqual(20, new NumberLetterCounts().Count(115));
        }
    }
}