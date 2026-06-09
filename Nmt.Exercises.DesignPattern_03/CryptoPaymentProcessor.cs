namespace Nmt.Exercises.DesignPattern_03
{
  public class CryptoPaymentProcessor : PaymentProcessor
  {
    public override IPaymentMethod CreatePaymentMethod() => new Crypto();
  }
}
