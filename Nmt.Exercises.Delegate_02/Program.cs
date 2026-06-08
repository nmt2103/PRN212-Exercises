namespace Nmt.Exercises.Delegate_02
{

  public delegate bool FilterDelegate(int number);

  public class Program
  {
    static List<int> FilterList(List<int> numbers, FilterDelegate filterMethod)
    {
      List<int> result = new List<int>();

      foreach (int number in numbers)
      {
        if (filterMethod(number))
          result.Add(number);
      }
      return result;
    }

    static void Main(string[] args)
    {
      NumberFilter filter = new NumberFilter();
      FilterDelegate filterMethod = null;

      List<int> numbers = new List<int> { 10, 15, 22, 33, 40, 55 };

      Console.WriteLine($"Original list: {string.Join(", ", numbers)}");

      Console.WriteLine("Select filter type: (1) Even numbers, (2) Odd numbers");

      string choice = Console.ReadLine();
      if (choice == "1")
      {
        filterMethod = filter.IsEven;
      }
      else if (choice == "2")
      {
        filterMethod = filter.IsOdd;
      }
      else
      {
        Console.WriteLine("Invalid choice!");
        return;
      }

      List<int> filterNumbers = FilterList(numbers, filterMethod);
      Console.WriteLine($"Filtered list: {string.Join(", ", filterNumbers)}");
    }
  }
}
