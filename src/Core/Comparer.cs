namespace Core;

public class Comparer<T>
where T : IComparable
{
    public int Compare(T a, T b)
    {
        return a.CompareTo(b);
    }
}
