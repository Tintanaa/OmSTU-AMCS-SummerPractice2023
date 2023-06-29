using SquareEquationLib;
using TechTalk.SpecFlow;
namespace Squarecov.Tests
{
    [Binding]
    public class Поиск_корнейКВУР
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

    public Поиск_корнейКВУР(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентами(double num0, double num1, double num2)
        {
            A = num0;
            B = num1;
            C = num2;
        }

        [Given(@"Квадратное уравнение с коэффициентами \(NaN, (.*), (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиNaN1(double num0, double num1)
        {
            A = double.NaN;
            B = num0;
            C = num1;
        }

        [Given(@"Квадратное уравнение с коэффициентами \((.*), NaN, (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиNaN2(double num0, double num2)
        {
            A = num0;
            B = double.NaN;
            C = num2;
        }

        [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), NaN\)")]
        public void КвадратноеУравнениеСКоэффициентамиNaN3(double num0, double num1)
        {
            A = num0;
            B = num1;
            C = double.NaN;
        }

        [Given(@"Квадратное уравнение с коэффициентами \(Double\.NegativeInfinity, (.*), (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity1(int num1, int num2)
        {
            A = double.NegativeInfinity;
            B = num1;
            C = num2;
        }

        [Given(@"Квадратное уравнение с коэффициентами \((.*), Double\.NegativeInfinity, (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity2(int num0, int num2)
        {
            A = num0;
            B = double.NegativeInfinity;
            C = num2;
        }
        [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), Double\.NegativeInfinity\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_NegativeInfinity3(int num0, int num1)
        {
            A = num0;
            B = num1;
            C = double.NegativeInfinity;
        }
        [Given(@"Квадратное уравнение с коэффициентами \(Double\.PositiveInfinity, (.*), (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity1(int num1, int num2)
        {
            A = double.PositiveInfinity;
            B = num1;
            C = num2;
        }
        [Given(@"Квадратное уравнение с коэффициентами \((.*), Double\.PositiveInfinity, (.*)\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity2(int num0, int num2)
        {
            A = num0;
            B = double.PositiveInfinity;
            C = num2;
        }
        [Given(@"Квадратное уравнение с коэффициентами \((.*), (.*), Double\.PositiveInfinity\)")]
        public void КвадратноеУравнениеСКоэффициентамиDouble_PositiveInfinity3(int num0, int num1)
        {
            A = num0;
            B = num1;
            C = double.PositiveInfinity;
        }
        [When(@"вычисляются корни квадратного уравнения")]
        public void вычисляются_корни_квадратного_уравнения()
        {
            try
            {
                Result = SquareEquation.Solve(A, B, C);
            }
            catch
            {
            }
        }
        [Then(@"квадратное уравнение имеет два корня \((.*), (.*)\) кратности один")]
        public void КвадратноеУравнениеИмеетДваКорняКратностиОдин(double num0, double num1)
        {
            double[] expected = { num0, num1 };
            Array.Sort(expected);
            Array.Sort(Result);
            Assert.Equal(expected, Result);
        }

        [Then(@"квадратное уравнение имеет один корень (.*) кратности два")]
        public void КвадратноеУравнениеИмеетОдинКореньКратностиДва(double num0)
        {
            double[] expected = { num0 };
            Assert.Equal(expected, Result);
        }

        [Then(@"множество корней квадратного уравнения пустое")]
        public void МножествоКорнейКвадратногоУравненияПустое()
        {
            double[] expected = { };
            Assert.Equal(expected, Result);
        }

        [Then(@"выбрасывается исключение ArgumentException")]
        public void ВыбрасываетсяИсключениеArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SquareEquation.Solve(A, B, C));
        }
    }
}

