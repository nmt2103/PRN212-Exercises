namespace Nmt.Exercises.DesignPattern_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      ConfigurationManager configManager = ConfigurationManager.GetInstance;

      Console.WriteLine("Initial Configuration:");
      configManager.ShowConfig();

      configManager.ConnectionString = "Server=remotehost;Database=NewDB;";

      Console.WriteLine("\nUpdated Configuration:");
      configManager.ShowConfig();

      ConfigurationManager anotherConfigManager = ConfigurationManager.GetInstance;

      Console.WriteLine("Configuration from another reference:");
      anotherConfigManager.ShowConfig();
    }
  }
}
