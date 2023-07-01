namespace UARMturn;
public class ShipTurn
{
    private bool _allowtoturn;
    private bool _degree;
    private bool _position;

    public bool allowtoturn { get => _allowtoturn; set => _allowtoturn = value; }
    public bool isdegree { get => _degree; set => _degree = value; }
    public bool isposition { get => _position; set => _position = value; }

    public double degree;
    public double position;
    public static double Shipmoving(double position, double Degree, bool IsAllow, bool IsPosition, bool IsDegree)
    {
        var SM = new ShipTurn();
        SM.position = position;
        SM.degree = Degree;
        SM.allowtoturn = IsAllow;
        SM.isposition = IsPosition;
        SM.isdegree = IsDegree;
        if (!(SM.allowtoturn) || !(SM.isposition) || !(SM.isdegree)) throw new Exception();
        return SM.position + SM.degree;
    }
}
