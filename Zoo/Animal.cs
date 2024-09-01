namespace Zoo;

public class Animal
{
    public string name;    // поле
    public string OwnerName { get; }    // свойство

    public Animal(string name, string ownerName)    // конструктор
    {
        this.name = name;
        OwnerName = ownerName;
    }

    public void Print()     // метод
    {
        Console.WriteLine($"Это {name}, его хозяена зовут {OwnerName}");
    }
}
