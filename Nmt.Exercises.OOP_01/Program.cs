namespace Nmt.Exercises.OOP_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      AnimalShelter animalShelter = new();

      Animal d1 = new Dog("Khang", 20, "Huynh");
      Animal c1 = new Cat("Luna", 2, true);
      Animal b1 = new Bird("Tweety", 1, true);
      Animal d2 = new Dog("Buddy", 3, "Golden Retriever");

      animalShelter.AddAnimal(d1);
      animalShelter.AddAnimal(c1);
      animalShelter.AddAnimal(b1);
      animalShelter.AddAnimal(d2);

      animalShelter.DisplayAll();

      Console.WriteLine($"Total count: {animalShelter.Count()}");
    }
  }
}
