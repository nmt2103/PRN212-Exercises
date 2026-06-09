namespace Nmt.Exercises.DesignPattern_03
{
  public class Crypto : IPaymentMethod
  {
    public void ProcessPayment() => Console.WriteLine("Paying by Crypto.");
  }
}
