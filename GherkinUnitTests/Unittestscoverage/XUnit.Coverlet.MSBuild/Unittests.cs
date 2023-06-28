using SquareEquationLib;
using TechTalk.SpecFlow;

[Binding]
public class �����_����������
{
    private readonly ScenarioContext _scenarioContext;
    private double _a;
    private double _b;
    private double _c;
    private double[] _result = new double[2];

    public ScenarioContext ScenarioContext => _scenarioContext;

    public double A { get => _a; set => _a = value; }
    public double B { get => _b; set => _b = value; }
    public double C { get => _c; set => _c = value; }
    public double[] Result { get => _result; set => _result = value; }

    public �����_����������(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"���������� ��������� � �������������� \((.*), (.*), (.*)\)")]
    public void ����������������������������������(double num0, double num1, double num2)
    {
        A = num0;
        B = num1;
        C = num2;
    }

    [Given(@"���������� ��������� � �������������� \(NaN, (.*), (.*)\)")]
    public void ����������������������������������NaN1(double num0, double num1)
    {
        A = double.NaN;
        B = num0;
        C = num1;
    }

    [Given(@"���������� ��������� � �������������� \((.*), NaN, (.*)\)")]
    public void ����������������������������������NaN2(double num0, double num2)
    {
        A = num0;
        B = double.NaN;
        C = num2;
    }

    [Given(@"���������� ��������� � �������������� \((.*), (.*), NaN\)")]
    public void ����������������������������������NaN3(double num0, double num1)
    {
        A = num0;
        B = num1;
        C = double.NaN;
    }

    [Given(@"���������� ��������� � �������������� \(Double\.NegativeInfinity, (.*), (.*)\)")]
    public void ����������������������������������Double_NegativeInfinity1(int num1, int num2)
    {
        A = double.NegativeInfinity;
        B = num1;
        C = num2;
    }

    [Given(@"���������� ��������� � �������������� \((.*), Double\.NegativeInfinity, (.*)\)")]
    public void ����������������������������������Double_NegativeInfinity2(int num0, int num2)
    {
        A = num0;
        B = double.NegativeInfinity;
        C = num2;
    }
    [Given(@"���������� ��������� � �������������� \((.*), (.*), Double\.NegativeInfinity\)")]
    public void ����������������������������������Double_NegativeInfinity3(int num0, int num1)
    {
        A = num0;
        B = num1;
        C = double.NegativeInfinity;
    }
    [Given(@"���������� ��������� � �������������� \(Double\.PositiveInfinity, (.*), (.*)\)")]
    public void ����������������������������������Double_PositiveInfinity1(int num1, int num2)
    {
        A = double.PositiveInfinity;
        B = num1;
        C = num2;
    }
    [Given(@"���������� ��������� � �������������� \((.*), Double\.PositiveInfinity, (.*)\)")]
    public void ����������������������������������Double_PositiveInfinity2(int num0, int num2)
    {
        A = num0;
        B = double.PositiveInfinity;
        C = num2;
    }
    [Given(@"���������� ��������� � �������������� \((.*), (.*), Double\.PositiveInfinity\)")]
    public void ����������������������������������Double_PositiveInfinity3(int num0, int num1)
    {
        A = num0;
        B = num1;
        C = double.PositiveInfinity;
    }
    [When(@"����������� ����� ����������� ���������")]
    public void �����������_�����_�����������_���������()
    {
        try
        {
            Result = SquareEquation.Solve(A, B, C);
        }
        catch
        {
        }
    }
    [Then(@"���������� ��������� ����� ��� ����� \((.*), (.*)\) ��������� ����")]
    public void ���������������������������������������������(double num0, double num1)
    {
        double[] expected = { num0, num1 };
        Array.Sort(expected);
        Array.Sort(Result);
        Assert.Equal(expected, Result);
    }

    [Then(@"���������� ��������� ����� ���� ������ (.*) ��������� ���")]
    public void ����������������������������������������������(double num0)
    {
        double[] expected = { num0 };
        Assert.Equal(expected, Result);
    }

    [Then(@"��������� ������ ����������� ��������� ������")]
    public void �����������������������������������������()
    {
        double[] expected = { };
        Assert.Equal(expected, Result);
    }

    [Then(@"������������� ���������� ArgumentException")]
    public void �����������������������ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => SquareEquation.Solve(A, B, C));
    }
}