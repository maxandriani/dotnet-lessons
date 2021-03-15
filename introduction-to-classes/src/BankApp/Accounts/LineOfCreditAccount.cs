using System;
using BankApp.Transactions;

namespace BankApp.Accounts
{
  public class LineOfCreditAccount : BankAccount
  {

    public LineOfCreditAccount(decimal initialBalance, string owner, decimal creditLimit) : this(initialBalance, new string[] { owner }, creditLimit) {}

    public LineOfCreditAccount(decimal initialBalance, string[] owners, decimal creditLimit) : base(initialBalance, owners, -creditLimit) {}

    public override void PerformMonthEndTransactions()
    {
      if (Balance < 0)
      {
        // Negate the balance to get a positive interest charge:
        var interest = -Balance * 0.07m;
        MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
      }
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
      isOverdrawn
      ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
      : default;

  }

}
