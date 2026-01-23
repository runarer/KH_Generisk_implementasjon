namespace Core;

public interface IStorable<T>
{
    public void Add(T obj);
    public bool TryGet(int index, out T? obj);
    public void RemoveAt(int index);

    public bool GetLast(out T? obj);

    public bool TryGetFirst(out T? obj);
}