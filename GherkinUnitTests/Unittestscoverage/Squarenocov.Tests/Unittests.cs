using UARMFlight;
using TechTalk.SpecFlow;

namespace UARMFlightTest
{
    [Binding]
    public class ИгровойОбъектМожетПеремещатьсяПоПрямой
    {
        private readonly ScenarioContext _scenarioContext;
        public List<(double, double)> _start = new List<(double, double)>();
        public List<(double, double)> _finish = new List<(double, double)>();
        public bool _isAllowToMove = true;
        public bool _IsSpeed = true;
        public bool _IsPosition = true;
        public List<(double, double)> _result = new List<(double, double)>();
        public ИгровойОбъектМожетПеремещатьсяПоПрямой(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
        public void ДопустимКосмическийКорабльНаходитсяВТочкеПространстваСКоординатами(double p0, double p1)
        {
            _start.Add((p0, p1));
        }

        [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
        public void ИИмеетМгновеннуюСкорость(double p0, double p1)
        {
            _finish.Add((p0, p1));
        }

        [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
        public void КосмическийКорабльПоложениеВПространствеКоторогоНевозможноОпределить()
        {
            _IsPosition = false;
        }

        [Given(@"скорость корабля определить невозможно")]
        public void CкоростьКорабляОпределитьНевозможно()
        {
            _IsSpeed = false;
        }

        [Given(@"изменить положение в пространстве космического корабля невозможно")]
        public void ИзменитьПоложениеВПространствеКосмическогоКорабляНевозможно()
        {
            _isAllowToMove = false;
        }

        [When(@"происходит прямолинейное равномерное движение без деформации")]
        public void ПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
        {
            try
            {
                _result.Add(UARMFlights.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
            }
            catch { }
        }

        [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
        public void КосмическийКорабльПеремещаетсяВТочкуПространстваСКоординатами(double p0, double p1)
        {
            List<(double, double)> expected = new List<(double, double)>
            {
                (p0, p1)
            };
            Assert.Equal(expected, _result);
        }

        [Then(@"возникает ошибка Exception")]
        public void ВозникаетОшибкаException()
        {
            Assert.Throws<Exception>(() => UARMFlights.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
        }
    }
}