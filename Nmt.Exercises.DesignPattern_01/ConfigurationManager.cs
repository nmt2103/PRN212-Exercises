namespace Nmt.Exercises.DesignPattern_01
{
  public class ConfigurationManager
  {
    // Step 1: Properties for configuration settings
    public string ConnectionString { get; set; } = "Server=localhost;Database=DB;";

    // Step 2: Create a private static instance variable
    private static ConfigurationManager _instance;

    // Step 3: Private constructor
    private ConfigurationManager() { }

    // Step 4: Public static property to access the instance
    public static ConfigurationManager GetInstance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new ConfigurationManager();
        }

        return _instance;
      }
    }

    // Step 5: Method to display configuration
    public void ShowConfig()
    {
      Console.WriteLine(_instance.ConnectionString);
    }
  }
}
