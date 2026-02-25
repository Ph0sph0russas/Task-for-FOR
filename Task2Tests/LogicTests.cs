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
        public void defaultTestForTaskA() 
        {
            double initialSum = 1000;
            double maxIncrease = 25;
            int answerA = Logic.getMonthOfExceededIncrease(initialSum, maxIncrease);
            Assert.AreEqual(13, answerA);
        }

        [TestMethod()]
        public void defaultTestForTaskB()
        {
            double initialSum = 1000;
            double maxDeposit = 2000;
            int answerB = Logic.getMonthOfExceededDeposit(initialSum, maxDeposit);
            Assert.AreEqual(36, answerB);
        }

        [TestMethod()]
        public void closeDistanceTestForTaskA()
        {
            double initialSum = 10000;
            double maxIncrease = 100;
            int answerA = Logic.getMonthOfExceededIncrease(initialSum, maxIncrease);
            Assert.AreEqual(1, answerA);
        }

        [TestMethod()]
        public void closeDistanceTestForTaskB()
        {
            double initialSum = 10000;
            double maxDeposit = 10000;
            int answerB = Logic.getMonthOfExceededDeposit(initialSum, maxDeposit);
            Assert.AreEqual(1, answerB);
        }

        [TestMethod()]
        public void farDistanceTestForTaskA()
        {
            double initialSum = 10000;
            double maxIncrease = 10000;
            int answerA = Logic.getMonthOfExceededIncrease(initialSum, maxIncrease);
            Assert.AreEqual(199, answerA);
        }

        [TestMethod()]
        public void farDistanceTestForTaskB()
        {
            double initialSum = 10000;
            double maxDeposit = 100000;
            int answerB = Logic.getMonthOfExceededDeposit(initialSum, maxDeposit);
            Assert.AreEqual(117, answerB);
        }

        [TestMethod()]
        public void defaultTestAllInOne()
        {
            double initialSum = 1000;
            double maxIncrease = 25;
            double maxDeposit = 2000;
            string realAnswer = Logic.calculateDepositInfo(initialSum, maxIncrease, maxDeposit);
            string expectedAnswer = "Ответ под а)13" + "\n" + "Ответ под б)36";
            Assert.AreEqual(expectedAnswer, realAnswer);
        }

        [TestMethod()]
        public void closeDistanceTestAllInOne()
        {
            double initialSum = 10000;
            double maxIncrease = 100;
            double maxDeposit = 10000;
            string realAnswer = Logic.calculateDepositInfo(initialSum, maxIncrease, maxDeposit);
            string expectedAnswer = "Ответ под а)1" + "\n" + "Ответ под б)1";
            Assert.AreEqual(expectedAnswer, realAnswer);
        }

        [TestMethod()]
        public void farDistanceTestAllInOne()
        {
            double initialSum = 10000;
            double maxIncrease = 10000;
            double maxDeposit = 100000;
            string realAnswer = Logic.calculateDepositInfo(initialSum,maxIncrease,maxDeposit);
            string expectedAnswer = "Ответ под а)199" + "\n" + "Ответ под б)117";
            Assert.AreEqual(expectedAnswer, realAnswer);
        }

    }
}