using Redmind_ATM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Redmind_ATM.UnitTest
{
    [TestClass]
    public class ATM_RedmindTest
    {
        [TestMethod]
        public void TestMethodCheckingTrueOrFalse()
        {
            //MSUnitTest for testing with different withdraws if its possbile or not with the existing bills (AAA Arrange, Act and Assert)

            //ARRANGE
            List<bool> testAtmWithdraws = new() { true, true, false, true, false, true, false };

            //ACT
            bool withdrawOne = Program.BillAmountCheck(1500);
            bool withdrawTwo = Program.BillAmountCheck(700);
            bool withdrawThree = Program.BillAmountCheck(400);
            bool withdrawFour = Program.BillAmountCheck(1100);
            bool withdrawFive = Program.BillAmountCheck(1000);
            bool withdrawSix = Program.BillAmountCheck(700);
            bool withdrawSeven = Program.BillAmountCheck(300);

            //ASSERT
            Assert.AreEqual(testAtmWithdraws[0], withdrawOne);
            Assert.AreEqual(testAtmWithdraws[1], withdrawTwo);
            Assert.AreEqual(testAtmWithdraws[2], withdrawThree);
            Assert.AreEqual(testAtmWithdraws[3], withdrawFour);
            Assert.AreEqual(testAtmWithdraws[4], withdrawFive);
            Assert.AreEqual(testAtmWithdraws[5], withdrawSix);
            Assert.AreEqual(testAtmWithdraws[6], withdrawSeven);
        }
    }
}
