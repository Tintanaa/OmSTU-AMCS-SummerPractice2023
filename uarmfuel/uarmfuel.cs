namespace UARMFuel
{
    public class ShipFuel
    {
        private double _FuelTaken;
        private double _FuelHas;

        public double fueltaken { get => _FuelTaken; set => _FuelTaken = value; }
        public double fuelhas { get => _FuelHas; set => _FuelHas = value; }

        public static double Shipfuelspending(double Fuelhas, double Fueltaken)
        {
            var SM = new ShipFuel();
            SM.fueltaken = Fueltaken;
            SM.fuelhas = Fuelhas;
            if (SM.fuelhas - SM.fueltaken < 0) throw new Exception();
            return SM.fuelhas - SM.fueltaken;
        }
    }
}
