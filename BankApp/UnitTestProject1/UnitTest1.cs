using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Amount_To_Balance()
        {
            var account = new Account(1000);

            account.Add(500);

            Assert.AreEqual(1500, account.Balance);
        }

        [TestMethod]
        public void withdram_Amount_To_Balance()
        {
            var account = new Account(1000);

            account.Withdraw(500);

            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Transfer_Amount_To_Balance()
        {
            var account = new Account(1000);
            var otherAccount = new Account();

            account.TransferFundsTo(otherAccount, 500);

            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Check_Account_Balance()
        {
            var account = new Account(20);
            var result =  account.AccountBalanceIsLow();
            Assert.IsTrue(result);
        }
    }
}
