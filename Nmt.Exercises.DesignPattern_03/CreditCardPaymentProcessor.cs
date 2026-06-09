namespace Nmt.Exercises.DesignPattern_03
{
  public class CreditCardPaymentProcessor : PaymentProcessor
  {
    public override IPaymentMethod CreatePaymentMethod() => new CreditCard();
  }
}
