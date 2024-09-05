namespace MyZoo;

public class Mammal : Animal
{
    private bool _isWarmBlooded = true;
    private int _gestationPeriod;

    public Mammal(string name, string species, int age, string diet, int gestationPeriod) : base(name, species, age, diet)
    {
        _gestationPeriod = gestationPeriod;
    }

}