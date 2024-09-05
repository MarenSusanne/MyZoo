namespace MyZoo;

public class Bird : Animal
{
    private bool _canFly;
    private int _wingSpan;


    public Bird(string name, string species, int age, string diet, bool canFly, int wingSpan) : base(name, species, age, diet)
    {
        _canFly = canFly;
        _wingSpan = wingSpan;
    }
    public override void Move()
    {
        if (_canFly)
        {
            Console.WriteLine($"{Name} the {Species} is flying");
        }
        else
        {
            Console.WriteLine($"{Name} the {Species} is walking");
        }

    }
}