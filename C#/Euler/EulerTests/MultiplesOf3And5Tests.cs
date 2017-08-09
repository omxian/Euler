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
    public class MultiplesOf3And5Tests
    {
        [TestMethod()]
        public void FindSumNumberSolution1Test()
        {
            Assert.AreEqual(23, new MultiplesOf3And5().FindSumNumberSolution1(10));
            Assert.AreEqual(233168, new MultiplesOf3And5().FindSumNumberSolution1(1000));
        }

        [TestMethod()]
        public void FindSumNumberSolution2Test()
        {
            for (int i = 1; i < 1001; i++)
            {
                Assert.AreEqual(
                   new MultiplesOf3And5().FindSumNumberSolution1(i),
                   new MultiplesOf3And5().FindSumNumberSolution2(i));
            }
        }
    }
}