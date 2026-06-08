namespace Nmt.Exercises.Delegate_03
{
  public class Display
  {
    public string? Name { get; set; }

    public Display() { }

    public Display(string name)
    {
      Name = name;
    }

    public void OnTempertureExceeded(object sender, TemperatureEventArgs e)
    {
      Console.WriteLine($"{Name}: ALERT! Temperture reached {e.Temperture}°C!");
    }
  }
}
