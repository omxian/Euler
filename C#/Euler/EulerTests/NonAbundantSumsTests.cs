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
    public class NonAbundantSumsTests
    {
        [TestMethod()]
        public void FindTest()
        {
            Assert.AreEqual(4179871, new NonAbundantSums().Find());
        }

        [TestMethod()]
        public void IsAbundantNumTest()
        {
            Assert.AreEqual(true,new NonAbundantSums().IsAbundantNum(12));
        }
    }
}