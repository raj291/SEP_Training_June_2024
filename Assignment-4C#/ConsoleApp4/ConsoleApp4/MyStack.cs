namespace ConsoleApp4;
using System.Collections.Generic;
public class MyStack<T>
{
    private List<T> stack = new List<T>();

    public int Count()
    {
        return stack.Count;
    }

    public void Push(T item)
    {
        stack.Add(item);
    }

    public T Pop()
    {
        T item = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return item;
    }
}