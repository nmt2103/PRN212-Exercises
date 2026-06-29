namespace Nmt.Exercises.LINQ_02
{
  public class Employee
  {
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public int Salary { get; set; }

    public override string? ToString()
    {
      return $"Id: {Id} - {Name} - Age: {Age} - {Address} - {City} - Salary: {Salary}";
    }
  }
}
