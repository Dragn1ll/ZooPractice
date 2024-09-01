namespace Zoo.Nasledovanie;

public class Rabbit : Gryzun
{
    public string OwnerName { get; init; }

    public Rabbit(string name, string ownerName) : base(name)
    {
        OwnerName = ownerName;
    }

    public override void Jump()
    {
        Console.WriteLine($"заяц {Name} прыгнул");
    }
}
