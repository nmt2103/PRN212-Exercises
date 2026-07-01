namespace Nmt.Exercises.OOP_01
{
  public class Bird : Animal
  {
    private bool _canFly;
    public bool CanFly
    {
      get => _canFly;
      set => _canFly = value;
    }

    public Bird(string? name, int age, bool canFly) : base(name, age)
    {
      CanFly = canFly;
    }

    public override string MakeSound()
    {
      return "Tweet";
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Can fly: {CanFly}, Sound: {MakeSound()}");
    }
  }
}
