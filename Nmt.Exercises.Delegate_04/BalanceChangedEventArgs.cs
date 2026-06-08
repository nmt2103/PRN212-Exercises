namespace Nmt.Exercises.Delegate_04
{
  public class BalanceChangedEventArgs : EventArgs
  {
    public BalanceChangedEventArgs() { }

    public BalanceChangedEventArgs(double newBalance)
    {
      NewBalance = newBalance;
    }

    public double NewBalance { get; }
  }
}
