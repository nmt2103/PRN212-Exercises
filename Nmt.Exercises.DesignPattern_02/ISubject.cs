namespace Nmt.Exercises.DesignPattern_02
{
  // Subject interface
  public interface ISubject
  {
    void Attach(IBitcoinPriceObserver observer);
    void Detach(IBitcoinPriceObserver observer);
    void Notify();
  }
}
