namespace SpaceShip;

class Program
{
    static void Main(string[] args)
    {
        Pool<SpaceShip> spaceShipPool = new Pool<SpaceShip>(200);
        using (PoolGuard<SpaceShip> guard = new(spaceShipPool))
        {
            SpaceShip spaceShip = guard.Object;
        }
    }
}
