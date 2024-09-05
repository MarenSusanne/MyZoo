namespace MyZoo
{
    public class Animal
    {
        public string Name;
        public string Species;
        public int Age;
        public string Diet;

        public Animal(string name, string species, int age, string diet)
        {
            Name = name;
            Species = species;
            Age = age;
            Diet = diet;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} the {Species} is eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} is sleeping");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} the {Species} is moving");
        }
    }
}
