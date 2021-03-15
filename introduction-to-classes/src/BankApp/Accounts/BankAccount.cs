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

    public BankAccount(decimal initialBalance, params string[] owners)
    {
      Owners = owners;
      Number = accountNumberSeed.ToString();
      accountNumberSeed++;

      MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

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
      if (Balance - amount < 0)
      {
          throw new InvalidOperationException("Not sufficient funds for this withdrawal!");
      }
      var withdrawal = new Transaction(-amount, date, note);
      transactions.Add(withdrawal);
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
  }

}