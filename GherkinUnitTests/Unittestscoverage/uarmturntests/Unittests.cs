using UARMturn;
using TechTalk.SpecFlow;

[Binding]
public class ѕоворот
{
    private readonly ScenarioContext _scenarioContext;
    private double _start;
    private double _degree;
    private bool _isAllowToTurn = true;
    private bool _IsDegree = true;
    private bool _IsPosition = true;
    private double _result;

    public double start { get => _start; set => _start = value; }
    public double degree { get => _degree; set => _degree = value; }
    public bool isallowtoturn { get => _isAllowToTurn; set => _isAllowToTurn = value; }
    public bool isdegree { get => _IsDegree; set => _IsDegree = value; }
    public bool isposition { get => _IsPosition; set => _IsPosition = value; }
    public double result { get => _result; set => _result = value; }

    public ѕоворот(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
    public void  осмический орабль»меет”голЌаклона(double p0)
    {
        start = p0;
    }

    [Given(@"имеет мгновенную угловую скорость (.*) град")]
    public void »»меетћгновенную”гловую—корость(double p0)
    {
        degree = p0;
    }

    [Given(@"космический корабль, угол наклона которого невозможно определить")]
    public void  осмический орабль”голЌаклона оторогоЌевозможноќпределить()
    {
        isposition = false;
    }

    [Given(@"мгновенную угловую скорость невозможно определить")]
    public void ћгновенную”гловую—коростьЌевозможноќпределить()
    {
        isdegree = false;
    }

    [Given(@"невозможно изменить угол наклона к оси OX космического корабл€")]
    public void Ќевозможно»зменить”голЌаклона ќсиOX осмического орабл€()
    {
        isallowtoturn = false;
    }

    [When(@"происходит вращение вокруг собственной оси")]
    public void ѕроисходит¬ращение¬округ—обственнойќси()
    {
        try
        {
            result = ShipTurn.Shipmoving(start, degree, isallowtoturn, isposition, isdegree);
        }
        catch { }
    }

    [Then(@"угол наклона космического корабл€ к оси OX составл€ет (.*) град")]
    public void ”голЌаклона осмического орабл€ ќсиOX—оставл€ет(double p0)
    {
        Assert.Equal(p0, result);
    }

    [Then(@"возникает ошибка Exception")]
    public void ¬озникаетќшибкаException()
    {
        Assert.Throws<Exception>(() => ShipTurn.Shipmoving(start, degree, isallowtoturn, isposition, isdegree));
    }
}