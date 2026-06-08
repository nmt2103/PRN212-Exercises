namespace Nmt.Exercises.Delegate_03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      TemperatureSensor sensor = new();

      Display display1 = new("Display A");
      Display display2 = new("Display B");

      sensor.TempertureExceeded += display1.OnTempertureExceeded;
      sensor.TempertureExceeded += display2.OnTempertureExceeded;

      double[] tempertures = { 25, 28, 31, 27, 35 };
      foreach (double value in tempertures)
      {
        sensor.CheckTemperture(value);
      }

      sensor.TempertureExceeded -= display2.OnTempertureExceeded;
      Console.WriteLine("\nDisplay B unsubscribed from event!\n");

      sensor.CheckTemperture(32);
    }
  }
}
