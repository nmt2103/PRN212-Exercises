namespace Nmt.Exercises.DesignPattern_03
{
  public abstract class PaymentProcessor
  {
    public abstract IPaymentMethod CreatePaymentMethod();

    public void Process()
    {
      IPaymentMethod paymentMethod = CreatePaymentMethod();

      Console.WriteLine("Payment: Processing payment...");
      paymentMethod.ProcessPayment();
    }
  }
}
