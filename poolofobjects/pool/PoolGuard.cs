namespace SpaceShip;

public class PoolGuard<T> : IDisposable where T : new()
{
    private readonly Pool<T> pool;
    private readonly T obj;
    public PoolGuard(Pool<T> pool)
    {
        this.pool = pool;
        obj = pool.GetObject();
    }
    public T Object => obj;
    public void Dispose() => pool.ReturnObject(obj);
}
