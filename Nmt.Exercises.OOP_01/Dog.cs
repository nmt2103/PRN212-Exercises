namespace Nmt.Exercises.OOP_01
{
  public class Dog : Animal
  {
    private string? _breed;

    public Dog(string? name, int age, string? breed) : base(name, age)
    {
      Breed = breed;
    }

    public string? Breed
    {
      get => _breed;
      set => _breed = value;
    }
    public override string MakeSound()
    {
      return "Woof";
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Breed: {Breed}, Sound: {MakeSound()}");
    }
  }
}
