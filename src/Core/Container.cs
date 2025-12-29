namespace Core;

public class Container<T> : IStorable<T> 
{
    private List<T> _content = [];
    public int Count {get; private set; } = 0;

    public void Add(T obj)
    {
        _content.Add(obj);
        ++Count;
    }

    public bool TryGet(int index, out T? obj)
    {
        obj = default(T);
        if(index >= Count)
            return false;
        obj = _content[index];
        return true;
    }

    public void RemoveAt(int index)
    {
        _content.RemoveAt(index);
        --Count;
    }
}