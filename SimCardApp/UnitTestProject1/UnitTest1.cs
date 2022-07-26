using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimCardApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Recharge_Moblie()
        {
            var amount = new SimCardAccount(1000);
            amount.Recharge(1000);
            Assert.AreEqual(2000,amount.Balance);
        }

        [TestMethod]
        public void Buy_Data_To_Moblie()
        {
            var amount = new SimCardAccount(1000);
            amount.BuyData(1000);
            Assert.AreEqual(0, amount.Balance);
        }

        [TestMethod]
        public void Borrow_Air_To_Mobile()
        {
            var amount = new SimCardAccount(0);
            amount.Recharge(1000);
            Assert.AreEqual(1000, amount.Balance);
        }

        [TestMethod]
        public void Transfer_To_Friends_Mobile()
        {
            var amount = new SimCardAccount(1000);
            var otherSim = new SimCardAccount();

            amount.TransferToFriends(otherSim, 500);

            Assert.AreEqual(500, amount.Balance);
            Assert.AreEqual(500, otherSim.Balance);
        }

        [TestMethod]
        public void Check_Air_Time_Balance()
        {
            var amount = new SimCardAccount(10);
            var result = amount.AirTimeBalanceIsLow();
            Assert.IsTrue(result);
        }
    }
}
