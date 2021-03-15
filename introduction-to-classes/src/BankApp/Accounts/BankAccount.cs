using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp.Transactions;

namespace BankApp.Accounts
{
  public class BankAccount
  {
    private static int accountNumberSeed = 1234567890;
    private readonly decimal minimumBalance;

    public string Number { get; }
    public string[] Owners { get; set; }

    private List<Transaction> transactions = new List<Transaction>();

    public string Owner
    {
      get => Owners.First();
    }

    public decimal Balance {
      get => transactions.Sum(t => t.Amount);
    }

    public BankAccount(decimal initialBalance, string owner): this(initialBalance, new string[] { owner }) {}

    public BankAccount(decimal initialBalance, string[] owners) : this(initialBalance, owners, 0) { }

    public BankAccount(decimal initialBalance, string[] owners, decimal minimumBalance)
    {
      Owners = owners;
      Number = accountNumberSeed.ToString();
      accountNumberSeed++;

      this.minimumBalance = minimumBalance;
      if (initialBalance > 0)
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

    public BankAccount(decimal initialBalance, string owner, decimal minimumBalance) : this(initialBalance, new string[] { owner }, minimumBalance) {}

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
          throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive!");
      }
      var deposit = new Transaction(amount, date, note);
      transactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
          throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive!");
      }
      var overdraftTransaction = CheckWithdrawalLimit(Balance - amount < minimumBalance);
      var withdrawal = new Transaction(-amount, date, note);
      transactions.Add(withdrawal);
      if (overdraftTransaction != null)
        transactions.Add(overdraftTransaction);
    }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
      if (isOverdrawn)
      {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      else
      {
        return default;
      }
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");

        foreach (var item in transactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }

    public virtual void PerformMonthEndTransactions() { }
  }

}