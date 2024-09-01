namespace Zoo.Nasledovanie;

public class Gryzun
{
    private int _id;
    public string Name { get; init; }

    public Gryzun(string name)
    {
        Name = name;
    }

    public virtual void Jump()
    {
        Console.WriteLine($"грызун {Name} прыгнул");
    }
}
