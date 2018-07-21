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
    public class NamesScoresTests
    {
        [TestMethod()]
        public void GetTotalScoresTest()
        {
            Assert.AreEqual(871198282, new NamesScores().GetTotalScores());
            Assert.AreEqual(53, new NamesScores().CountWord("COLIN"));
        }
    }
}