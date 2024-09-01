namespace Zoo;

public class ZooWorker : IComparer<Animal>
{
    public int Compare(Animal? x, Animal? y)
    {
        return x.name == y.name ? 1 : -1;
    }
}
