using System.Text.Json;

namespace Nmt.Exercises.LINQ_02
{
  public class Program
  {
    static void Main(string[] args)
    {
      string filePath = Path.Combine(AppContext.BaseDirectory, "employees.json");

      if (!File.Exists(filePath))
      {
        Console.WriteLine($"Error: {filePath} not exist!");
        return;
      }

      string strEmployees = File.ReadAllText(filePath);

      List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(strEmployees);

      // Employee age between 30 - 50
      Console.WriteLine("Employee age between 30 - 50:");
      foreach (Employee employee in employees.Where(e => e.Age >= 30 && e.Age <= 50))
        Console.WriteLine(employee);

      // Group by city
      Console.WriteLine("Employee group by city:");
      foreach (var city in employees.GroupBy(e => e.City))
      {
        Console.WriteLine($"City: {city.Key}");
        foreach (var employee in city)
        {
          Console.WriteLine(employee);
        }
      }

      // Lowest salary
      Console.WriteLine("Lowest salary:");
      Console.WriteLine(employees.OrderBy(e => e.Salary).First());

      // Search name
      Console.Write("Search: ");
      string keyword = Console.ReadLine();
      List<Employee> searchEmployees = new();
      foreach (Employee employee in employees)
      {
        if (employee.Name.Contains(keyword))
        {
          searchEmployees.Add(employee);
        }
      }

      if (searchEmployees.Count == 0)
      {
        Console.WriteLine("Not found.");
      }
      else
      {
        searchEmployees.ForEach(e => Console.WriteLine(e));
      }

      // Is older than 60
      Console.WriteLine("Is age > 60:");
      Console.WriteLine(employees.Any(e => e.Age > 60) ? "Yes" : "No");
    }
  }
}
