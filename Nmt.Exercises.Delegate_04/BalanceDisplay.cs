namespace Nmt.Exercises.Delegate_04
{
  public class BalanceDisplay
  {
    public void ShowBalance(Object sender, BalanceChangedEventArgs e)
    {
      Console.WriteLine($"New balance: ${e.NewBalance}");
    }
  }
}
