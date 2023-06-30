namespace UARMFlight
{
    public class UARMFlights
    {
        private bool move_flag;
        private bool speed_flag;
        private bool position_flag;

        public List<(double, double)> _Speed = new List<(double, double)>();
        public List<(double, double)> _Position = new List<(double, double)>();

        public bool moveflag { get => move_flag; set => move_flag = value; }
        public bool speedflag { get => speed_flag; set => speed_flag = value; }
        public bool positionflag { get => position_flag; set => position_flag = value; }

        public List<(double, double)> Speed
        {
            get => _Speed;
            set => _Speed = value;
        }
        public List<(double, double)> Position
        {
            get => _Position;
            set => _Position = value;
        }

        public static (double, double) Shipmoving
            (List<(double, double)> position, List<(double, double)> speed, bool IsAllow, bool IsPosition, bool IsSpeed)
        {
            var SM = new UARMFlights
            {
                moveflag = IsAllow,
                positionflag = IsPosition,
                speedflag = IsSpeed,
                Position = position,
                Speed = speed
            };
            if (!(SM.moveflag) || !(SM.positionflag) || !(SM.speedflag)) throw new Exception();
            double x = SM.Position[0].Item1 + SM.Speed[0].Item1;
            double y = SM.Position[0].Item2 + SM.Speed[0].Item2;
            return (x, y);
        }
    }
    public class ShipFuel
    {
        private double _FuelTaken;
        private double _FuelHas;

        public double fueltaken { get => _FuelTaken; set => _FuelTaken = value; }
        public double fuelhas { get => _FuelHas; set => _FuelHas = value; }

        public static double Shipmoving(double Fuelhas, double Fueltaken)
        {
            var SM = new ShipFuel();
            SM.fueltaken = Fueltaken;
            SM.fuelhas = Fuelhas;
            if (SM.fuelhas - SM.fueltaken < 0) throw new Exception();
            return SM.fuelhas - SM.fueltaken;
        }
    }
    public class ShipTurn
    {
        private bool _AllowToTurn;
        private bool _IsDegree;
        private bool _IsPosition;

        public double _Degree;
        public double _Position;
        public static double Shipmoving(double position, double Degree, bool IsAllow, bool IsPosition, bool IsDegree)
        {
            var SM = new ShipTurn();
            SM._Position = position;
            SM._Degree = Degree;
            SM._AllowToTurn = IsAllow;
            SM._IsPosition = IsPosition;
            SM._IsDegree = IsDegree;
            if (!(SM._AllowToTurn) || !(SM._IsPosition) || !(SM._IsDegree)) throw new Exception();
            return SM._Position + SM._Degree;
        }
    }
}
