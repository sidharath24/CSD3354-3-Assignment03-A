using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C0724144_C0732134
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Harpuspam Nanan\nSidharath Aggarwal", beginningBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.0001, "Account not debited correctly");
        }

        [TestMethod]

        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningbalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Harpuspam Nanan\nSidharath Aggarwal", beginningbalance);

            //act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAEBM);
            }

            //
        }
    }
}
