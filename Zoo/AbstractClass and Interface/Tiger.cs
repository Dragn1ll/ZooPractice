namespace Zoo;

public class Tiger : Predator, IGrowlable
{
    public override string Name { get; }

    public Tiger(string name)
    {
        Name = name;
    }

    public override void Eat(Animal animal)
    {
        Console.WriteLine($"{Name} сьел животное по имени {animal.name}");
    }

    public void Growl()
    {
        Console.WriteLine("раааааааар");
    }
}
