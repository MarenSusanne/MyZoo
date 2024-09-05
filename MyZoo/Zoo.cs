namespace MyZoo;

public class Zoo
{
    public Enclosure MammalEnclosure = new Enclosure("MammalEnclosure") { };
    public Enclosure BirdEnclosure = new Enclosure("BirdEnclosure");
    public Enclosure ReptileEnclosure = new Enclosure("ReptileEnclosure");
    public Zookeeper Roger = new Zookeeper("Roger", 5, 21300);

    public Zoo()
    {
        MammalEnclosure.AddAnimal(new Mammal("Leonora", "Lion", 2, MyZoo.Enclosure.Diets.Carnivore.ToString(), 110));
        MammalEnclosure.AddAnimal(new Mammal("Ellie", "Elephant", 3, MyZoo.Enclosure.Diets.Herbivore.ToString(), 660));

        BirdEnclosure.AddAnimal(new Bird("Peppa", "Parrot", 8, MyZoo.Enclosure.Diets.Herbivore.ToString(), true, 48));
        BirdEnclosure.AddAnimal(new Bird("Preben", "Penguin", 9, MyZoo.Enclosure.Diets.Carnivore.ToString(), false, 80));

        ReptileEnclosure.AddAnimal(new Reptile("Bert", "Boa", 5, MyZoo.Enclosure.Diets.Carnivore.ToString(), false));
        ReptileEnclosure.AddAnimal(new Reptile("Candace", "Crocodile", 17, MyZoo.Enclosure.Diets.Carnivore.ToString(), true));
    }
}