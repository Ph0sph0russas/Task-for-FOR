using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void defaultTest()
        {
            double a = 1000;
            double b = 25;
            double c = 2000;
            int answerA = Logic.monthOfIncrease(a, b);
            int answerB = Logic.monthOfDeposit(a, c);
            Assert.AreEqual(13, answerA);
            Assert.AreEqual(36, answerB);
        }

        [TestMethod()]
        public void closeDistanceTest()
        {
            double a = 10000;
            double b = 100;
            double c = 10000;
            int answerA = Logic.monthOfIncrease(a, b);
            int answerB = Logic.monthOfDeposit(a, c);
            Assert.AreEqual(1, answerA);
            Assert.AreEqual(1, answerB);
        }
        [TestMethod()]
        public void farDistanceTest()
        {
            double a = 10000;
            double b = 10000;
            double c = 100000;
            int answerA = Logic.monthOfIncrease(a, b);
            int answerB = Logic.monthOfDeposit(a, c);
            Assert.AreEqual(199, answerA);
            Assert.AreEqual(117, answerB);
        }
    }
}