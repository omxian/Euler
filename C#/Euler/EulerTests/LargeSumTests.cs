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
    public class LargeSumTests
    {
        [TestMethod()]
        public void LargeSumTests_SolutionTest()
        {
            Assert.AreEqual("5537376230", new LargeSum().Solution(50,100));
        }
    }
}