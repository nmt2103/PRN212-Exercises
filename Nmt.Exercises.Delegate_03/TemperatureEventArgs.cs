namespace Nmt.Exercises.Delegate_03
{
  public class TemperatureEventArgs : EventArgs
  {
    public double Temperture { get; set; }

    public TemperatureEventArgs() { }

    public TemperatureEventArgs(double temperture)
    {
      Temperture = temperture;
    }
  }
}
