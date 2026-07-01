namespace Nmt.Exercises.OOP_02
{
  public class Manager : FullTimeEmployee
  {
    private double _bonus;

    public Manager(int id, string? name, string? department, double monthlySalary, double bonus) : base(id, name, department, monthlySalary)
    {
      Bonus = bonus;
    }

    public double Bonus
    {
      get => _bonus;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException("Bonus cannot be negative!");
        _bonus = value;
      }
    }

    public override double CalcalateSalary()
    {
      return base.CalcalateSalary() + Bonus;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Bonus: {Bonus} | Total: {CalcalateSalary()}");
    }
  }
}
