namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double x1;
        double x2;
        double[] array = new double[2];
        double eps = 1e-9;
        double d = b * b - 4 * a * c;
        if (-eps < a & a < eps)
        {
            throw new ArgumentException();
        }
        if (a == 0 || new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException();
        }
        if (d<=-eps)
        {
            array = new double[0];
        }
        else if (-eps < d & d < eps)
        {
            x1 = -(b)/(2*a);
            array = new double[] { x1 };
        }
        else 
        {
            if (Math.Sign(b)==0)
            { x1 = (-b + Math.Sqrt(d)) / (2 * a); }
            else { x1 = (-b + Math.Sign(b) * Math.Sqrt(d)) / (2 * a); }
            x2 = c /(a*x1);
            array = new double[] { x1, x2 };
        }
        return array;
    }
}
