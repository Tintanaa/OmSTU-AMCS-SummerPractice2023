namespace SalonLib;
public class ServiceLocator
{
    private static IDictionary<string, Func<string>> store;

    static ServiceLocator()
    {
        store = new Dictionary<string, Func<string>>();
    }

    public static string GetService(string key)
    {
        return store[key].Invoke();
    }

}
