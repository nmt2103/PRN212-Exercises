namespace Nmt.Exercises.Delegate_04
{
  public class BankAccount
  {
    public event EventHandler<BalanceChangedEventArgs>? BalanceChanged;

    private double _balance;

    public BankAccount()
    {
    }

    public BankAccount(double balance)
    {
      Balance = balance;
    }

    public double Balance
    {
      get { return _balance; }

      set
      {
        if (_balance != value)
        {
          _balance = value;

          BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(_balance));
        }
      }
    }

    public void Deposit(double amount)
    {
      Console.WriteLine($"Deposit: ${amount}");

      Balance += amount;
    }

    public void Withdraw(double amount)
    {
      if (Balance < amount)
      {
        Console.WriteLine("Insufficient funds or invalid amount!");
        return;
      }

      Console.WriteLine($"Withdraw: ${amount}");

      Balance -= amount;
    }
  }
}
