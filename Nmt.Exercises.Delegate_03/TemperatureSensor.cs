namespace Nmt.Exercises.Delegate_03
{
  public class TemperatureSensor
  {
    public event EventHandler<TemperatureEventArgs>? TempertureExceeded;

    public void CheckTemperture(double temperture)
    {
      Console.WriteLine($"Current Temperture: {temperture}°C");

      if (temperture > 30)
      {
        Console.WriteLine("Warning: High Temperture!");

        TempertureExceeded?.Invoke(this, new TemperatureEventArgs(temperture));
      }
    }
  }
}
