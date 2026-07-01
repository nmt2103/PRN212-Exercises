namespace Nmt.Exercises.OOP_01
{
  public abstract class Animal
  {
    private string? _name;
    public string? Name
    {
      get => _name;
      set => _name = value;
    }

    private int _age;
    public int Age
    {
      get => _age;
      set
      {
        if (value >= 0)
          _age = value;
        else
          throw new ArgumentOutOfRangeException("Age cannot be negative.");
      }
    }

    protected Animal(string? name, int age)
    {
      Name = name;
      Age = age;
    }

    public abstract string MakeSound();

    public virtual void DisplayInfo()
    {
      Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
  }
}
