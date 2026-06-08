namespace Nmt.Exercises.Delegate
{
  public class Calculator
  {
    public double Add(double a, double b) { return a + b; }

    public double Subtract(double a, double b) { return b - a; }

    public double Multiply(double a, double b) { return a * b; }

    public double Divide(double a, double b)
    {
      return b != 0 ? a / b : throw new
        DivideByZeroException("Error: Division by zero is not allowed.");
    }
  }
}
