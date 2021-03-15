using System;

namespace BankApp.Accounts
{
  public class GiftCardAccount : BankAccount
  {

    private decimal monthlyDeposit;

    public GiftCardAccount(decimal initialBalance, string owner, decimal monthlyDeposit = 0) : this(initialBalance, new string[] { owner }, monthlyDeposit) {}
    public GiftCardAccount(decimal initialBalance, string[] owners, decimal monthlyDeposit) : base(initialBalance, owners)
      => this.monthlyDeposit = monthlyDeposit;

    public override void PerformMonthEndTransactions()
    {
      if (monthlyDeposit != 0)
      {
        MakeDeposit(monthlyDeposit, DateTime.Now, "Add monthly deposit");
      }
    }

  }
}