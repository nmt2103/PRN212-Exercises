namespace Nmt.Exercises.Generic_03
{
  public class Repository<T> where T : class
  {
    private List<T> _list = new();

    public void Add(T item) => _list.Add(item);

    public void Remove(T item) => _list.Remove(item);

    public void DisplayAll() => _list.ForEach(item => Console.WriteLine(item));
  }
}
