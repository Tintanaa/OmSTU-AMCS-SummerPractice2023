using UARMturn;
using TechTalk.SpecFlow;

[Binding]
public class �������
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

    public �������(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"����������� ������� ����� ���� ������� (.*) ���� � ��� OX")]
    public void ����������������������������������(double p0)
    {
        start = p0;
    }

    [Given(@"����� ���������� ������� �������� (.*) ����")]
    public void �������������������������������(double p0)
    {
        degree = p0;
    }

    [Given(@"����������� �������, ���� ������� �������� ���������� ����������")]
    public void ���������������������������������������������������������()
    {
        isposition = false;
    }

    [Given(@"���������� ������� �������� ���������� ����������")]
    public void ���������������������������������������������()
    {
        isdegree = false;
    }

    [Given(@"���������� �������� ���� ������� � ��� OX ������������ �������")]
    public void ���������������������������������OX�������������������()
    {
        isallowtoturn = false;
    }

    [When(@"���������� �������� ������ ����������� ���")]
    public void ��������������������������������������()
    {
        try
        {
            result = ShipTurn.Shipmoving(start, degree, isallowtoturn, isposition, isdegree);
        }
        catch { }
    }

    [Then(@"���� ������� ������������ ������� � ��� OX ���������� (.*) ����")]
    public void ����������������������������������OX����������(double p0)
    {
        Assert.Equal(p0, result);
    }

    [Then(@"��������� ������ Exception")]
    public void ���������������Exception()
    {
        Assert.Throws<Exception>(() => ShipTurn.Shipmoving(start, degree, isallowtoturn, isposition, isdegree));
    }
}