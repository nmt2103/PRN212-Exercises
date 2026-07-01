namespace Nmt.Exercises.OOP_02
{
  public abstract class Employee : IStaff
  {
    private int _id;
    private string? _name;
    private string? _department;

    public Employee(int id, string? name, string? department)
    {
      Id = id;
      Name = name;
      Department = department;
    }

    public int Id { get => _id; set => _id = value; }
    public string? Name { get => _name; set => _name = value; }
    public string? Department { get => _department; set => _department = value; }

    public abstract double CalcalateSalary();

    public virtual void DisplayInfo()
    {
      Console.WriteLine($"ID: {Id} | Name: {Name} | Dept: {Department}");
    }
  }
}
