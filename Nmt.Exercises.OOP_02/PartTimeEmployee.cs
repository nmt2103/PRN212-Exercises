namespace Nmt.Exercises.OOP_02
{
  public class PartTimeEmployee : Employee
  {
    private double _hourlyRate;
    private int _hoursWorked;

    public PartTimeEmployee(int id, string? name, string? department, double hourlyRate, int hoursWorked) : base(id, name, department)
    {
      HourlyRate = hourlyRate;
      HoursWorked = hoursWorked;
    }

    public double HourlyRate
    {
      get => _hourlyRate;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException("Hourly rate cannot be negetive!");
        _hourlyRate = value;
      }
    }

    public int HoursWorked
    {
      get => _hoursWorked;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException("Hours worked cannot be negetive!");
        _hoursWorked = value;
      }
    }

    public override double CalcalateSalary()
    {
      return HourlyRate * HoursWorked;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Type: Part-Time | {HoursWorked}h x {HourlyRate} = {CalcalateSalary()}");
    }
  }
}
