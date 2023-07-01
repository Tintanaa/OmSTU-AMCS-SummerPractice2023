using TechTalk.SpecFlow;
using UARMFuel;

namespace uarmfueltests
{
    [Binding]
    public class “опливо орабл€
    {
        private readonly ScenarioContext _scenarioContext;
        private double _fuelhas;
        private double _fueltaken;
        private double _result;

        public double fuelhas { get => _fuelhas; set => _fuelhas = value; }
        public double fueltaken { get => _fueltaken; set => _fueltaken = value; }
        public double result { get => _result; set => _result = value; }
        public “опливо орабл€(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
        public void ƒопустим осмический орабль»меет“опливо¬ќбъеме(double p0)
        {
            fuelhas = p0;
        }

        [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
        public void »меет—корость–асхода“опливаѕриƒвижении(double p0)
        {
            fueltaken = p0;
        }

        [When(@"происходит пр€молинейное равномерное движение без деформации")]
        public void ѕроисходитѕр€молинейное–авномерноеƒвижениеЅезƒеформации()
        {
            try
            {
                result = ShipFuel.Shipfuelspending(fuelhas, fueltaken);
            }
            catch { }
        }

        [Then(@"новый объем топлива космического корабл€ равен (.*) ед")]
        public void Ќовыйќбъем“оплива осмического орабл€–авен(double p0)
        {
            Assert.Equal(p0, result);
        }

        [Then(@"возникает ошибка Exception")]
        public void ¬озникаетќшибкаException()
        {
            Assert.Throws<Exception>(() => ShipFuel.Shipfuelspending(fuelhas, fueltaken));
        }
    }
}