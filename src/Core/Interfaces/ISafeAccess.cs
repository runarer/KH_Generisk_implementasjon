namespace Core;

public interface ISafeAccess<T>
{
    public bool TryGet(int index, out T? obj);

    public bool TryGetLast(out T? obj);

    public bool TryGetFirst(out T? obj);
}