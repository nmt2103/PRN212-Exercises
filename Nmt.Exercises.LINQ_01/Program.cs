namespace Nmt.Exercises.LINQ_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>
        {
          -45, -23, 12, 67, -89, 34, -56, 78, -12, 90, 15, -32, 45, 67, -23, 12,
          -5, 88, -45, 27, 90, -76, 45, -34, 23, 56, -67, 89, 12, -8, 77, -90, 11,
          33, -21, 40, 67, -55, 29, -44, 0, -12, 39, -88, 54, 76, -33, 19, 27, -60,
          31, -49, 82, -73, 65, -41, 77, 23, -8, 99, -99, 55, -66, 44, -22, 33, -77,
          88, -55, 11, 22, -33, 66, -44, 77, -22, 99, -88, 12, -11, 20, -30, 40, -50,
          60, -70, 80, -90, 100, -20, 25, -35, 45, -55, 65, -75, 85, -95, 15, -25
        };

      // Largest number
      Console.WriteLine(numbers.Max(num => num));

      // Smallest number
      Console.WriteLine(numbers.Min(num => num));

      // Amount of numbers divisible by 3
      Console.WriteLine(numbers.Count(num => num % 3 == 0));

      // Remove duplicate
      numbers.Distinct().ToList().ForEach(num => Console.Write($"{num} "));

      Console.WriteLine();

      // Retrieve three largest numbers
      numbers.OrderByDescending(num => num).Take(3).ToList().ForEach(num => Console.Write($"{num} "));
    }
  }
}
