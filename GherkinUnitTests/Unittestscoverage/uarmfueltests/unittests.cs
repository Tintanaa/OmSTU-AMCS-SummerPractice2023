using TechTalk.SpecFlow;
using UARMFuel;

namespace uarmfueltests
{
    [Binding]
    public class ��������������
    {
        private readonly ScenarioContext _scenarioContext;
        private double _fuelhas;
        private double _fueltaken;
        private double _result;

        public double fuelhas { get => _fuelhas; set => _fuelhas = value; }
        public double fueltaken { get => _fueltaken; set => _fueltaken = value; }
        public double result { get => _result; set => _result = value; }
        public ��������������(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"����������� ������� ����� ������� � ������ (.*) ��")]
        public void ���������������������������������������������(double p0)
        {
            fuelhas = p0;
        }

        [Given(@"����� �������� ������� ������� ��� �������� (.*) ��")]
        public void ��������������������������������������(double p0)
        {
            fueltaken = p0;
        }

        [When(@"���������� ������������� ����������� �������� ��� ����������")]
        public void �������������������������������������������������������()
        {
            try
            {
                result = ShipFuel.Shipfuelspending(fuelhas, fueltaken);
            }
            catch { }
        }

        [Then(@"����� ����� ������� ������������ ������� ����� (.*) ��")]
        public void �����������������������������������������(double p0)
        {
            Assert.Equal(p0, result);
        }

        [Then(@"��������� ������ Exception")]
        public void ���������������Exception()
        {
            Assert.Throws<Exception>(() => ShipFuel.Shipfuelspending(fuelhas, fueltaken));
        }
    }
}