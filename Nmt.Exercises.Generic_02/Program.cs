namespace Nmt.Exercises.Generic_02
{
  public class Program
  {
    public static void Swap<T>(ref T a, ref T b)
    {
      T temp = a;
      a = b;
      b = temp;
    }

    static void Main(string[] args)
    {
      // # Testing with int
      // Before swap
      int x = 5, y = 10;
      Console.WriteLine($"Before swap (int): x: {x} --- y: {y}");

      // Swaping
      Swap(ref x, ref y);

      // After swap
      Console.WriteLine($"After swap (int): x: {x} --- y: {y}");

      // # Testing with string
      string str1 = "Hello", str2 = "World";
      Console.WriteLine($"Before swap (string): str1: {str1} --- str2: {str2}");
      Swap(ref str1, ref str2);
      Console.WriteLine($"After swap (string): str1: {str1} --- str2: {str2}");

      // # Testing with double
      double d1 = 1.5, d2 = 2.5;
      Console.WriteLine($"Before swap (double): d1: {d1} --- d2: {d2}");
      Swap(ref d1, ref d2);
      Console.WriteLine($"After swap (double): d1: {d1} --- d2: {d2}");
    }
  }
}
