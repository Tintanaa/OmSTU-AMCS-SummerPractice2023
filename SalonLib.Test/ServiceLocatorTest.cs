namespace SalonLib.Test;

public class ServiceLocatorTest
{
    [Fact]
    public void Service1Test()
    {
        var expected = "В читальном зале";
        var actual = SalonLib.ServiceLocator.GetService("Читать стихи");
        Assert.Equal(expected, actual);
    }
}
