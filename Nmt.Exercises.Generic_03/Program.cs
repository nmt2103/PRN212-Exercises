namespace Nmt.Exercises.Generic_03
{
  public class Program
  {
    static void Main(string[] args)
    {
      Repository<Student> studentRepo = new();

      studentRepo.Add(new Student { Id = 1, Name = "Alice" });

      Student bob = new Student { Id = 2, Name = "Bob" };
      studentRepo.Add(bob);

      studentRepo.Add(new Student { Id = 3, Name = "Charlie" });

      studentRepo.DisplayAll();
      studentRepo.Remove(bob);
      studentRepo.DisplayAll();
    }
  }
}
