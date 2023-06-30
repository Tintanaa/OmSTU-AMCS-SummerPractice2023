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
}
