namespace Nmt.Exercises.Console_02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("No employee names provided. Please run the program with employee names as arguments.");
        return;
      }

      List<string> employees = [];

      foreach (string arg in args)
      {
        string fullName = arg.Replace("_", " ");
        employees.Add(fullName);
      }

      Console.WriteLine("Search: ");
      string? prompt = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(prompt))
      {
        Console.WriteLine("Invalid input. Please enter a non-empty search string.");
        return;
      }

      bool found = false;
      foreach (string employee in employees)
      {
        if (employee.ToLower().Contains(prompt.ToLower()))
        {
          Console.WriteLine(employee);
          found = true;
        }
      }

      if (!found)
      {
        Console.WriteLine("No employees found with that search term.");
      }
    }
  }
}
