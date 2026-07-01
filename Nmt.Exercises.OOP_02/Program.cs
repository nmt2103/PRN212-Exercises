namespace Nmt.Exercises.OOP_02
{
  public class Program
  {
    static void Main(string[] args)
    {
      Payroll p = new();

      Employee fullTimeEmp = new FullTimeEmployee(1, "Nguyen Van A", "IT", 15000000);
      Employee partTimeEmp1 = new PartTimeEmployee(2, "Le Thi B", "Marketing", 100000, 80);
      Employee manager = new Manager(3, "Tran Van C", "IT", 25000000, 5000000);
      Employee partTimeEmp2 = new PartTimeEmployee(4, "Pham Thi D", "HR", 90000, 60);

      p.AddEmployee(fullTimeEmp);
      p.AddEmployee(partTimeEmp1);
      p.AddEmployee(manager);
      p.AddEmployee(partTimeEmp2);

      p.DisplayAll();

      Console.WriteLine($"Total Payroll: {p.GetTotalSalary()}");
    }
  }
}
