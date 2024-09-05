namespace MyZoo;

public class Enclosure
{
    public List<Animal> Animals = new();
    public string Name;

    public Enclosure(string name)
    {
        Name = name;
    }
    public enum Diets
    {
        Herbivore,
        Carnivore,
        Omnivore
    }
    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}