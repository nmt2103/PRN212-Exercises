namespace Nmt.Exercises.DesignPattern_02
{
  // Subject: Bitcoin Price Tacker
  public class BitcoinPriceTracker : ISubject
  {
    private List<IBitcoinPriceObserver> _observers = new();
    private decimal _latestPrice;

    public void UpdatePrice(decimal price)
    {
      _latestPrice = price;
      Console.WriteLine($"Bitcoin: Updated ${price}");
      Notify();
    }

    // Attach an observer
    public void Attach(IBitcoinPriceObserver observer) => _observers.Add(observer);

    // Detach an observer
    public void Detach(IBitcoinPriceObserver observer) => _observers.Remove(observer);

    // Notify all observers
    public void Notify()
    {
      foreach (var observer in _observers)
      {
        observer.Update(_latestPrice);
      }
    }
  }
}
