namespace Nmt.Exercises.DesignPattern_02
{
  // Observer Interface
  public interface IBitcoinPriceObserver
  {
    // Notifies the observers about a Bitcoin price change
    void Update(decimal price);
  }
}
