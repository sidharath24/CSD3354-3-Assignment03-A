using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C0724144_C0732134
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void Debit_WithValidAmount_UpdatesBalance()
            {
                //Arrange
                double beginningBalance = 11.99;
                double debitAmount = 4.55;
                double expected = 7.44;
                BankAccount account = new BankAccount("Mr. Harpuspam Singh Nanan\nMr. Sidharath Aggarwal", beginningBalance);

                //Act
                account.Debit(debitAmount);

                //Assert
                double actual = account.Balance;
                Assert.AreEqual(expected, actual, 0.0001, "Account nt debited correctly");
            }
        }
    }
}
