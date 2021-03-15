using System;
using BankApp.Accounts;

namespace BankApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount(1000, "Max");
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
      Console.WriteLine(account.Balance);
      account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
      Console.WriteLine(account.Balance);

      try
      {
          var invalidAccount = new BankAccount(-55, "invalid");
      }
      catch (ArgumentOutOfRangeException e)
      {
          Console.WriteLine("Exception caught creating account with negative balance");
          Console.WriteLine(e.ToString());
      }

      Console.WriteLine(account.GetAccountHistory());
    }
  }
}
