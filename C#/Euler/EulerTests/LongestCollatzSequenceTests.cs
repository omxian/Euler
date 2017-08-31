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
    public class LongestCollatzSequenceTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            Assert.AreEqual(837799, new LongestCollatzSequence().Solution1(1000000));
        }
    }
}