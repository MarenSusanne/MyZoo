namespace MyZoo;

public class Reptile : Animal
{
    private bool _isColdBlooded = true;
    private bool _laysEggs;

    public Reptile(string name, string species, int age, string diet, bool laysEggs) : base(name, species, age, diet)
    {
        _laysEggs = laysEggs;
    }

}