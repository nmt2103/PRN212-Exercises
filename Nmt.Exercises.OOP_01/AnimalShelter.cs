namespace Nmt.Exercises.OOP_01
{
  public class AnimalShelter
  {
    private List<Animal> _animals = [];

    public void AddAnimal(Animal animal)
    {
      _animals.Add(animal);
      Console.WriteLine($"Added: {animal.Name}");
    }

    public void DisplayAll() => _animals.ForEach(animal => animal.DisplayInfo());

    public int Count() => _animals.Count();
  }
}
