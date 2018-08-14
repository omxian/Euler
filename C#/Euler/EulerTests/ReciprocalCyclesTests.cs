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
    public class ReciprocalCyclesTests
    {
        [TestMethod()]
        public void FindTest()
        {
            //现有算法都通过了验证但是效率太低了
            Assert.AreEqual(983, new ReciprocalCycles().Find(1000));
            //Assert.AreEqual(1979, new ReciprocalCycles().Find(2000));
            //Assert.AreEqual(9967, new ReciprocalCycles().Find(10000));
            //Assert.AreEqual(24989, new ReciprocalCycles().Find(25000));
        }

        [TestMethod()]
        public void CanFindNextTest()
        {
            Assert.AreEqual(true, new ReciprocalCycles().NextStr("004761490476149", "0476149", 1));
            Assert.AreEqual(true, new ReciprocalCycles().NextStr("0033333", "3", 1));
            Assert.AreEqual(true, new ReciprocalCycles().NextStr("142857142857142857", "142857", 0));
        }
    }
}