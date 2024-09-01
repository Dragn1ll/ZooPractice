namespace Zoo;

public abstract class Predator
{
    public abstract string Name { get; }
    
    public abstract void Eat(Animal animal);
}
