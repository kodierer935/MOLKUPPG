using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJU23v_DTP_T4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJU23v_DTP_T4.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestsPow()
        {
            Assert.AreEqual(IntMath.Pow(2, 10), 1024);
            Assert.AreEqual(IntMath.Pow(3, 3), 27);
        }
        [TestMethod()]
        public void TestsFact()
        {
            Assert.AreEqual(IntMath.Fact(6), 720);
            Assert.AreEqual(IntMath.Fact(18), 6402373705728000);
            Assert.AreEqual(IntMath.Fact(0), 1);
        }
        [TestMethod()]
        public void TestsTria()
        {
            Assert.AreEqual(IntMath.Tria(4), 10);
            Assert.AreEqual(IntMath.Tria(10), 55);
        }
        [TestMethod()]
        public void TestsGCD()
        {
            Assert.AreEqual(IntMath.GCD(12, 16), 4);
            Assert.AreEqual(IntMath.GCD(133, 70), 7);
            Assert.AreEqual(IntMath.GCD(1, 2), 1);
        }
    }
}