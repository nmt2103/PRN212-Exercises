namespace Nmt.Exercises.OOP_02
{
  public class Payroll
  {
    private List<Employee> _employees = [];

    public void AddEmployee(Employee employee) => _employees.Add(employee);

    public void DisplayAll()
    {
      foreach (Employee emp in _employees)
        emp.DisplayInfo();
    }

    public double GetTotalSalary()
    {
      double sum = 0;

      foreach (Employee emp in _employees)
        sum += emp.CalcalateSalary();

      return sum;
    }
  }
}
