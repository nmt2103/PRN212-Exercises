namespace Nmt.Exercises.Generic_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      LuckyMoneyEnvelope<int> envelope1 = new LuckyMoneyEnvelope<int>(100);
      envelope1.Display();

      LuckyMoneyEnvelope<string> envelope2 = new LuckyMoneyEnvelope<string>("Happy New Year!");
      envelope2.Display();

      LuckyMoneyEnvelope<double> envelope3 = new LuckyMoneyEnvelope<double>(68.68);
      envelope3.Display();
    }
  }
}
