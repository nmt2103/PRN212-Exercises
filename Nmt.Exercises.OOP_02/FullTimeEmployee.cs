namespace Nmt.Exercises.OOP_02
{
  public class FullTimeEmployee : Employee
  {
    private double _monthlySalary;

    public FullTimeEmployee(int id, string? name, string? department, double monthlySalary) : base(id, name, department)
    {
      MonthlySalary = monthlySalary;
    }

    public double MonthlySalary
    {
      get => _monthlySalary;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException("Monthly salary cannot be negative!");
        _monthlySalary = value;
      }
    }

    public override double CalcalateSalary()
    {
      return MonthlySalary;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Type: Full-Time | Salary: {CalcalateSalary()}");
    }
  }
}
