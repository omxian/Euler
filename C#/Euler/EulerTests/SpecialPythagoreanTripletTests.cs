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
    public class SpecialPythagoreanTripletTests
    {
        [TestMethod()]
        public void SpecialPythagoreanTriplet_Solution1Test()
        {
            Assert.AreEqual(31875000,new SpecialPythagoreanTriplet().Solution1(1000));
        }
    }
}