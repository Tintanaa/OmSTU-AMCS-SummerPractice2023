namespace SpaceShip;

public class Pool<T> where T : new()
{
    private readonly Queue<T> pool;
    public Pool(int initialCapacity)
    {
        pool = new Queue<T>(initialCapacity);
        for (int i = 0; i < initialCapacity; i++)
        {
            pool.Enqueue(new T());
        }
    }
    public T GetObject()
    {
        if (pool.Count > 0)
        {
            return pool.Dequeue();
        }
        else
        {
            return new T();
        }
    }
    public void ReturnObject(T obj) => pool.Enqueue(obj);
}
