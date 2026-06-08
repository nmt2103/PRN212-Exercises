namespace Nmt.Exercises.Delegate_04
{
  public class Program
  {
    static void Main(string[] args)
    {
      BankAccount account = new(1000);

      BalanceDisplay display = new();

      TransactionLogger logger = new();

      account.BalanceChanged += display.ShowBalance;
      account.BalanceChanged += logger.LogTransaction;

      account.Deposit(500);
      account.Withdraw(200);
      account.Withdraw(2000);
      account.Deposit(300);

      Console.WriteLine("Unsubscribing the transaction logger...");
      account.BalanceChanged -= logger.LogTransaction;

      account.Withdraw(100);
      account.Deposit(400);
    }
  }
}
