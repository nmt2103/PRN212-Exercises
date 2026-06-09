namespace Nmt.Exercises.DesignPattern_03
{
  public class Program
  {
    static void Main(string[] args)
    {
      PaymentProcessor creditCardMethod = new CreditCardPaymentProcessor();
      creditCardMethod.Process();

      PaymentProcessor cryptoMethod = new CryptoPaymentProcessor();
      cryptoMethod.Process();

      PaymentProcessor paypalMethod = new PaypalPaymentProcessor();
      paypalMethod.Process();
    }
  }
}
