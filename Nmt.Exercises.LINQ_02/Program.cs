using Microsoft.Extensions.Configuration;

namespace Nmt.Exercises.LINQ_02
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new();

      IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile("employees.json")
        .Build();

      Console.WriteLine(config);

      // Employee age between 30 - 50
      foreach (Employee employee in employees.Where(e => e.Age >= 30 && e.Age <= 50))
        Console.WriteLine(employee);

      // Group by city
      foreach (Employee employee in employees.GroupBy(e => e.City))
        Console.WriteLine(employee);

      // Lowest salary
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
      searchEmployees.ForEach(e => Console.WriteLine(e));

      Console.WriteLine(employees.Any(e => e.Age > 60) ? "Yes" : "No");
    }
  }
}
