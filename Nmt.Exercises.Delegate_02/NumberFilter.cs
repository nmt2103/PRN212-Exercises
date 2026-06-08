namespace Nmt.Exercises.Delegate_02
{
  public class NumberFilter
  {
    public bool IsEven(int number)
    {
      return number % 2 == 0;
    }

    public bool IsOdd(int number)
    {
      return (number % 2 != 0);
    }
  }
}
