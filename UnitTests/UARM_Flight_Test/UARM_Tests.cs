using UARM_Flight;
using TechTalk.SpecFlow;

namespace SpaceBattleTests
{
    [Binding]
    public class ��������������������������������������
    {
        private readonly ScenarioContext _scenarioContext;
        public List<(double, double)> _start = new List<(double, double)>();
        public List<(double, double)> _finish = new List<(double, double)>();
        public bool _isAllowToMove = true;
        public bool _IsSpeed = true;
        public bool _IsPosition = true;
        public List<(double, double)> _result = new List<(double, double)>();
        public ��������������������������������������(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"����������� ������� ��������� � ����� ������������ � ������������ \((.*), (.*)\)")]
        public void ������������������������������������������������������������������(double p0, double p1)
        {
            _start.Add((p0, p1));
        }

        [Given(@"����� ���������� �������� \((.*), (.*)\)")]
        public void ������������������������(double p0, double p1)
        {
            _finish.Add((p0, p1));
        }

        [Given(@"����������� �������, ��������� � ������������ �������� ���������� ����������")]
        public void ��������������������������������������������������������������������()
        {
            _IsPosition = false;
        }

        [Given(@"�������� ������� ���������� ����������")]
        public void C����������������������������������()
        {
            _IsSpeed = false;
        }

        [Given(@"�������� ��������� � ������������ ������������ ������� ����������")]
        public void �����������������������������������������������������������()
        {
            _isAllowToMove = false;
        }

        [When(@"���������� ������������� ����������� �������� ��� ����������")]
        public void �������������������������������������������������������()
        {
            try
            {
                _result.Add(UARM_Flight.UARM_Flight.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
            }
            catch { }
        }

        [Then(@"����������� ������� ������������ � ����� ������������ � ������������ \((.*), (.*)\)")]
        public void �������������������������������������������������������������(double p0, double p1)
        {
            List<(double, double)> expected = new List<(double, double)>
            {
                (p0, p1)
            };
            Assert.Equal(expected, _result);
        }

        [Then(@"��������� ������ Exception")]
        public void ���������������Exception()
        {
            Assert.Throws<Exception>(() => UARM_Flight.UARM_Flight.Shipmoving(_start, _finish, _isAllowToMove, _IsPosition, _IsSpeed));
        }
    }
}