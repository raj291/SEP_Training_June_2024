namespace ConsoleApp4;

public interface IRepository<T>
{
    public void Add(T item);
    public void Remove(T item);
    public void Save();
    public T GetById(int d);
    IEnumerable<T> GetAll();
}