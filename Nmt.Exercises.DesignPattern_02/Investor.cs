namespace Nmt.Exercises.DesignPattern_02
{
  // Concrete Observer: Investor
  public class Investor : IBitcoinPriceObserver
  {
    // Prop to store Investor's name
    public string Name { get; set; }

    // Constructor to init the Investor with a name
    public Investor(string name) => Name = name;

    public void Update(decimal price)
    {
      Console.WriteLine($"{Name} notified: Bitcoin price is now ${price}");
    }
  }
}
