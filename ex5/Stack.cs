namespace ex5;

public class Stack <T>
{
    List<T> _list=new List<T>();
    public void Push(T item)
    {
        _list.Add(item);
    }
    public T Pop()
    {
        var lastnum=_list.Last();
        _list.Remove(lastnum);
        return lastnum;
    }
    public T Peek()
    {
        return _list.Last();
    }
}
