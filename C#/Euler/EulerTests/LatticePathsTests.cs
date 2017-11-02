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
    public class LatticePathsTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(2, new LatticePaths().Solution2(1, 1));
            Assert.AreEqual(6, new LatticePaths().Solution2(2, 2));
            Assert.AreEqual(20, new LatticePaths().Solution2(3, 3));
            Assert.AreEqual(70, new LatticePaths().Solution2(4, 4));
            Assert.AreEqual(252, new LatticePaths().Solution2(5, 5));
            Assert.AreEqual(924, new LatticePaths().Solution2(6, 6));
            Assert.AreEqual(184756, new LatticePaths().Solution2(10, 10));
            Assert.AreEqual(155117520, new LatticePaths().Solution2(15, 15));
            Assert.AreEqual(601080390, new LatticePaths().Solution2(16, 16));
            Assert.AreEqual(137846528820, new LatticePaths().Solution2(20, 20));
        }
    }
}