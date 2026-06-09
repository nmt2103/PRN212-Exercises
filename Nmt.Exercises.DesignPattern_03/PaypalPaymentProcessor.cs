namespace Nmt.Exercises.DesignPattern_03
{
  public class PaypalPaymentProcessor : PaymentProcessor
  {
    public override IPaymentMethod CreatePaymentMethod() => new Paypal();
  }
}
