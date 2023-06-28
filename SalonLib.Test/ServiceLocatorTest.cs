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

    [Fact]
    public void Service2Test()
    {
        var expected = "У рояля";
        var actual = SalonLib.ServiceLocator.GetService("Петь романсы");
        Assert.Equal(expected, actual);
    }
}
