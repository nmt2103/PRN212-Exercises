namespace Nmt.Exercises.Delegate
{

  public delegate double OperationDelegate(double a, double b);

  public class Program
  {
    static void Main(string[] args)
    {
      Calculator calc = new Calculator();

      OperationDelegate operation = null;

      Console.WriteLine("Enter the first number: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second number: ");
      double num2 = double.Parse(Console.ReadLine());

      Console.WriteLine("\nSelect an operation: `+` `-` `*` `/`");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "+":
          operation = calc.Add;
          break;

        case "-":
          operation = calc.Subtract;
          break;

        case "*":
          operation = calc.Multiply;
          break;

        case "/":
          operation = calc.Divide;
          break;

        default:
          Console.WriteLine("\nInvalid operation!");
          return;
      }

      double result = operation(num1, num2);
      Console.WriteLine($"\nResult: {num1} {choice} {num2} = {result}");
    }
  }
}
