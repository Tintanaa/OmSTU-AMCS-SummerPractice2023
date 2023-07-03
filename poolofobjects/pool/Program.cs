namespace SpaceShip;

class Program
{
    static void Main(string[] args)
    {
        Pool<SpaceShip> spaceShipPool = new Pool<SpaceShip>(10);
        using (PoolGuard<SpaceShip> guard = new(spaceShipPool))
        {
            SpaceShip spaceShip = guard.Object;
        }
    }
}
