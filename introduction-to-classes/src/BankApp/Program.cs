using System;
using BankApp.Accounts;

namespace BankApp
{
  class Program
  {
    static void Main(string[] args)
    {
      AccountTests();
      Separator();
      AccountExceptionTest();
      Separator();
      GiftCardTests();
      Separator();
      InterestTests();
      Separator();
      CreditTests();
      Separator();
      CreditTest2();

      Console.ReadKey();
    }

    private static void Separator()
    {
      Console.WriteLine();
      Console.WriteLine("==========================================================");
    }

    private static void AccountTests()
    {
      var account = new BankAccount(1000, "Max");
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
      Console.WriteLine(account.Balance);
      account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
      Console.WriteLine(account.Balance);

      Console.WriteLine(account.GetAccountHistory());
    }

    private static void AccountExceptionTest()
    {
       try
      {
          var invalidAccount = new BankAccount(-55, "invalid");
      }
      catch (ArgumentOutOfRangeException e)
      {
          Console.WriteLine("Exception caught creating account with negative balance");
          Console.WriteLine(e.ToString());
      }
    }

    private static void GiftCardTests()
    {
      var giftCard = new GiftCardAccount(100, "Gift Card", 50);
      giftCard.MakeWithdrawal(20, DateTime.Now, "Get expensive coffee");
      giftCard.MakeWithdrawal(50, DateTime.Now, "Buy groceries");
      giftCard.PerformMonthEndTransactions();
      // can make additional deposits:
      giftCard.MakeDeposit(27.50m, DateTime.Now, "Add some additional spending money");
      Console.WriteLine(giftCard.GetAccountHistory());
    }

    private static void InterestTests()
    {
      var savings = new InterestEarningAccount(10000, "Savings Account");
      savings.MakeDeposit(750, DateTime.Now, "Save some money");
      savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
      savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
      savings.PerformMonthEndTransactions();
      Console.WriteLine(savings.GetAccountHistory());
    }

    private static void CreditTests()
    {
      var lineOfCredit = new LineOfCreditAccount(0, "Line of Credit", 2000);
      // How much is too much to borrow?
      try {
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
      } catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      
      lineOfCredit.PerformMonthEndTransactions();
      Console.WriteLine(lineOfCredit.GetAccountHistory());
    }

    private static void CreditTest2()
    {
      var lineOfCredit = new LineOfCreditAccount(0, "Line of Credit", 2000);
      // How much is too much to borrow?
      lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
      lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
      lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
      lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
      lineOfCredit.PerformMonthEndTransactions();
      Console.WriteLine(lineOfCredit.GetAccountHistory());
    }
  }
}
