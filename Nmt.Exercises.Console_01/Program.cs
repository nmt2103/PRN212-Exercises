namespace Nmt.Exercises.Console_01
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[] employees =
      {
                "Nguyen Van A",
                "Le Thi B",
                "Hoang Anh",
                "Tran Van C",
                "Thanh An"
            };

      Console.WriteLine("Enter: ");
      string? prompt = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(prompt))
      {
        Console.WriteLine("Invalid input. Please enter a non-empty search string.");
        return;
      }

      bool found = false;
      foreach (var employee in employees)
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
