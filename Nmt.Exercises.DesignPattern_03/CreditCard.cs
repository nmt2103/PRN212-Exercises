namespace Nmt.Exercises.DesignPattern_03
{
  public class CreditCard : IPaymentMethod
  {
    public void ProcessPayment() => Console.WriteLine("Paying by credit card.");
  }
}
