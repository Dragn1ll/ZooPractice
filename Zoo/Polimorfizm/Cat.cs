using Zoo.Nasledovanie;

namespace Zoo.Polimorfizm;

public class Cat
{
    public string Name { get; }
    public int Age { get; }

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Catch(Gryzun gryzun)
    {
        if (new Random().Next(10) < 5)
            Console.WriteLine($"{Name} поймал грызуна {gryzun.Name}");
    }

    public void Meet(Predator predator)
    {
        Console.WriteLine($"{Name} прорычал на хищника {predator.Name}");
    }

    public void Meet(ZooWorker worker)
    {
        Console.WriteLine($"{Name} мяукнул работнику зоопарка");
    }
}
