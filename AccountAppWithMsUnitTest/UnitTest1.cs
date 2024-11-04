using AccountAppWithMsUnitTest.Exceptions;
using AccountAppWithMsUnitTest.Models;

namespace AccountAppWithMsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Account account1;
        private Account account2;

        public UnitTest1()
        {
            account1 = new Account(1, "shravani", "SBI", 1000);
            account2 = new Account(2, "shirisha", "Union", 500);
        }

        [TestMethod]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            double expectedResult = 1500;
            account1.DepositAmount(500);
            double actualResult = account1.GetBalance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Deposit_InvalidAmount_ThrowsInvalidAmountException()
        {
            Assert.ThrowsException<InvalidAmountException>(() => account1.DepositAmount(-500));
        }

        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            account1.WithdrawAmount(300);
            Assert.AreEqual(700, account1.GetBalance());
        }

        [TestMethod]
        public void Withdraw_AmountExceedingBalance_ThrowsInsufficientBalanceException()
        {
            Assert.ThrowsException<InsufficientBalanceException>(() => account1.WithdrawAmount(800)); 
        }

        [TestMethod]
        public void Withdraw_InvalidAmount_ThrowsInvalidAmountException()
        {
            Assert.ThrowsException<InvalidAmountException>(() => account1.WithdrawAmount(-500));
        }

        [TestMethod]
        public void Transfer_ValidAmount_UpdatesBothBalances()
        {
            account1.TransferAmount(account2, 200);

            Assert.AreEqual(800, account1.GetBalance());
            Assert.AreEqual(700, account2.GetBalance());
        }

        [TestMethod]
        public void Transfer_InvalidAmount_ThrowsInvalidAmountException()
        {
            Assert.ThrowsException<InvalidAmountException>(() => account1.TransferAmount(account2, -200));
        }

        [TestMethod]
        public void Transfer_AmountExceedingBalance_ThrowsInsufficientBalanceException()
        {
            Assert.ThrowsException<InsufficientBalanceException>(() => account1.TransferAmount(account2, 800));
        }

        [TestMethod]
        public void Transfer_NullAccount_ThrowsInvalidAccountException()
        {
            Assert.ThrowsException<InvalidAccountException>(() => account1.TransferAmount(null, 200));
        }

        [TestMethod]
        public void GetBalance_AfterDeposit_ReturnsCorrectBalance()
        {
            account1.DepositAmount(500);
            Assert.AreEqual(1500, account1.GetBalance());
        }

        [TestMethod]
        public void GetBalance_AfterTransfer_ReturnsCorrectBalance()
        {
            account1.TransferAmount(account2, 200);

            Assert.AreEqual(800, account1.GetBalance());
            Assert.AreEqual(700, account2.GetBalance());
        }
    }
}