namespace MyZoo;

public class Menu
{
    Zoo zoo = new Zoo();
    public void Start()
    {
        Console.WriteLine("Welcome to the Zoo!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine($" 1. Visit the {zoo.MammalEnclosure.Name}\n 2. Visit the {zoo.BirdEnclosure.Name}\n 3. Visit the {zoo.ReptileEnclosure.Name}");
    }
}