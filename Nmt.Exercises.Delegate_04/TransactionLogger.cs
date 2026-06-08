namespace Nmt.Exercises.Delegate_04
{
  public class TransactionLogger
  {
    public void LogTransaction(Object sender, BalanceChangedEventArgs e)
    {
      Console.WriteLine($"[LOG] Account balance updated: ${e.NewBalance}");
    }
  }
}
