namespace Nmt.Exercises.OOP_01
{
  public class Cat : Animal
  {
    private bool _isIndoor;
    public bool IsIndoor
    {
      get => _isIndoor;
      set => _isIndoor = value;
    }

    public Cat(string? name, int age, bool isIndoor) : base(name, age)
    {
      IsIndoor = isIndoor;
    }

    public override string MakeSound()
    {
      return "Meow";
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Indoor: {IsIndoor}, Sound: {MakeSound()}");
    }
  }
}
