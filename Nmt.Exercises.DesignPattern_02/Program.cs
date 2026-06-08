namespace Nmt.Exercises.DesignPattern_02
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Create Subject (Bitcoin Price Tracker)
      BitcoinPriceTracker priceTracker = new();

      // Create Observers (Investors)
      Investor investor1 = new("Alice");
      Investor investor2 = new("Bob");

      // Register Observer
      priceTracker.Attach(investor1);
      priceTracker.Attach(investor2);

      // Update Bitcoin price
      priceTracker.UpdatePrice(50000);
      priceTracker.UpdatePrice(52000);

      // Remove an investor
      priceTracker.Detach(investor1);

      // Update Bitcoin price again
      priceTracker.UpdatePrice(53000);
    }
  }
}
