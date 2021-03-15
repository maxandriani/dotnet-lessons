using System;

namespace BankApp.Accounts
{
  public class InterestEarningAccount : BankAccount
  {

    public InterestEarningAccount(decimal initialBalance, string owner) : this(initialBalance, new string[] { owner }) {}
    public InterestEarningAccount(decimal initialBalance, string[] owners) : base(initialBalance, owners)
    {
    }

    public override void PerformMonthEndTransactions()
    {
      if (Balance > 500m)
      {
        var interest = Balance * 0.05m;
        MakeDeposit(interest, DateTime.Now, "Apply monthly interest");
      }
    }

  }
}