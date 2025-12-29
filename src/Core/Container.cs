namespace Core;

public class Container<T> : IStorable<T> 
{
    public List<T> Content {get; private set;} = [];
    public int Count {get; private set; } = 0;
    
    public void Add(T obj)
    {
        Content.Add(obj);
        ++Count;
    }

    public bool TryGet(int index, out T? obj)
    {
        obj = default(T);
        if(index < 0 || index >= Count)
            return false;
        obj = Content[index];
        return true;
    }

    public void RemoveAt(int index)
    {
        Content.RemoveAt(index);
        --Count;
    }
}