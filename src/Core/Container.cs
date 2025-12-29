namespace Core;

public class Container<T> : IStorable<T> 
{
    private List<T> _content = [];
    private int _count = 0;

    public void Add(T obj)
    {
        _content.Add(obj);
        ++_count;
    }

    public bool TryGet(int index, out T? obj)
    {
        obj = default(T);
        if(index >= _count)
            return false;
        obj = _content[index];
        return true;
    }

    public void RemoveAt(int index)
    {
        _content.RemoveAt(index);
        --_count;
    }
}