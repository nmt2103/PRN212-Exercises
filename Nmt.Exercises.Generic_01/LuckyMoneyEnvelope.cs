namespace Nmt.Exercises.Generic_01
{
  public class LuckyMoneyEnvelope<T>
  {
    public LuckyMoneyEnvelope(T item)
    {
      Item = item;
    }

    public T Item { get; set; }

    public void Display()
    {
      Console.WriteLine(Item);
    }
  }
}
