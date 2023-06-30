using UARM_Flight;
using TechTalk.SpecFlow;

namespace SpaceBattleTests
{
    [Binding]
    public class »гровойќбъектћожетѕеремещатьс€ѕоѕр€мой
    {
        private readonly ScenarioContext _scenarioContext;
        public List<(double, double)> _start = new List<(double, double)>();
        public List<(double, double)> _finish = new List<(double, double)>();
        public bool _isAllowToMove = true;
        public bool _IsSpeed = true;
        public bool _IsPosition = true;
        public List<(double, double)> _result = new List<(double, double)>();
        public »гровойќбъектћожетѕеремещатьс€ѕоѕр€мой(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"космический корабль находитс€ в точке пространства с координатами \((.*), (.*)\)")]
        public void ƒопустим осмический орабльЌаходитс€¬“очкеѕространства— оординатами(double p0, double p1)
        {
            _start.Add((p0, p1));
        }

        [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
        public void »»меетћгновенную—корость(double p0, double p1)
        {
            _finish.Add((p0, p1));
        }

        [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
        public void  осмический орабльѕоложение¬ѕространстве оторогоЌевозможноќпределить()
        {
            _IsPosition = false;
        }

        [Given(@"скорость корабл€ определить невозможно")]
        public void Cкорость орабл€ќпределитьЌевозможно()
        {
            _IsSpeed = false;
        }

        [Given(@"изменить положение в пространстве космического корабл€ невозможно")]
        public void »зменитьѕоложение¬ѕространстве осмического орабл€Ќевозможно()
        {
            _isAllowToMove = false;
        }

        [When(@"происходит пр€молинейное равномерное движение без деформации")]
        public void ѕроисходитѕр€молинейное–авномерноеƒвижениеЅезƒеформации()
        {
            try
            {
                _result.Add(UARM_Flight.UARM_Flight.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
            }
            catch { }
        }

        [Then(@"космический корабль перемещаетс€ в точку пространства с координатами \((.*), (.*)\)")]
        public void  осмический орабльѕеремещаетс€¬“очкуѕространства— оординатами(double p0, double p1)
        {
            List<(double, double)> expected = new List<(double, double)>
            {
                (p0, p1)
            };
            Assert.Equal(expected, _result);
        }

        [Then(@"возникает ошибка Exception")]
        public void ¬озникаетќшибкаException()
        {
            Assert.Throws<Exception>(() => UARM_Flight.UARM_Flight.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
        }
    }
}