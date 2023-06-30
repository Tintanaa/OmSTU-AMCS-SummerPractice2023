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
    [Binding]
    public class ТопливоКорабля
    {
        private readonly ScenarioContext _scenarioContext;
        private double _fuelhas;
        private double _fueltaken;
        private double _result;
        public ТопливоКорабля(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
        public void ДопустимКосмическийКорабльИмеетТопливоВОбъеме(double p0)
        {
            _fuelhas = p0;
        }

        [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
        public void ИмеетСкоростьРасходаТопливаПриДвижении(double p0)
        {
            _fueltaken = p0;
        }

        [When(@"происходит прямолинейное равномерное движение без деформации")]
        public void ПроисходитПрямолинейноеРавномерноеДвижениеБезДеформации()
        {
            try
            {
                _result = ShipFuel.Shipmoving(_fuelhas, _fueltaken);
            }
            catch { }
        }

        [Then(@"новый объем топлива космического корабля равен (.*) ед")]
        public void НовыйОбъемТопливаКосмическогоКорабляРавен(double p0)
        {
            Assert.Equal(p0, _result);
        }

        [Then(@"возникает ошибка Exception")]
        public void ВозникаетОшибкаException()
        {
            Assert.Throws<Exception>(() => ShipFuel.Shipmoving(_fuelhas, _fueltaken));
        }
    }
    public class Поворот
    {
        private readonly ScenarioContext _scenarioContext;
        private double _start;
        private double _degree;
        private bool _isAllowToTurn = true;
        private bool _IsDegree = true;
        private bool _IsPosition = true;
        private double _result;
        public Поворот(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
        public void КосмическийКорабльИмеетУголНаклона(double p0)
        {
            _start = p0;
        }

        [Given(@"имеет мгновенную угловую скорость (.*) град")]
        public void ИИмеетМгновеннуюУгловуюСкорость(double p0)
        {
            _degree = p0;
        }

        [Given(@"космический корабль, угол наклона которого невозможно определить")]
        public void КосмическийКорабльУголНаклонаКоторогоНевозможноОпределить()
        {
            _IsPosition = false;
        }

        [Given(@"мгновенную угловую скорость невозможно определить")]
        public void МгновеннуюУгловуюСкоростьНевозможноОпределить()
        {
            _IsDegree = false;
        }

        [Given(@"невозможно изменить угол наклона к оси OX космического корабля")]
        public void НевозможноИзменитьУголНаклонаКОсиOXКосмическогоКорабля()
        {
            _isAllowToTurn = false;
        }

        [When(@"происходит вращение вокруг собственной оси")]
        public void ПроисходитВращениеВокругСобственнойОси()
        {
            try
            {
                _result = ShipTurn.Shipmoving(_start, _degree, _isAllowToTurn, _IsPosition, _IsDegree);
            }
            catch { }
        }

        [Then(@"угол наклона космического корабля к оси OX составляет (.*) град")]
        public void УголНаклонаКосмическогоКорабляКОсиOXСоставляет(double p0)
        {
            Assert.Equal(p0, _result);
        }

        [Then(@"возникает ошибка Exception")]
        public void ВозникаетОшибкаException()
        {
            Assert.Throws<Exception>(() => ShipTurn.Shipmoving(_start, _degree, _isAllowToTurn, _IsPosition, _IsDegree));
        }
    }
}