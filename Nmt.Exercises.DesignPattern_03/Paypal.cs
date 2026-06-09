namespace Nmt.Exercises.DesignPattern_03
{
  public class Paypal : IPaymentMethod
  {
    public void ProcessPayment() => Console.WriteLine("Paying by PayPal.");
  }
}
