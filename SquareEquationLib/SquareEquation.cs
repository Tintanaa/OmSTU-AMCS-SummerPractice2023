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
        if (-eps < a && a < eps)
        {
            throw new System.ArgumentException();
        }
        if (a == 0 || new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException("Ошибка");
        }
        if (d<=-eps)
        {
            array = new double[0];
        }
        else if (-eps < d && d < eps)
        {
            x1 = -b/(2*a);
            array = new double[] { x1 };
        }
        else 
        {
            x1 = (2*c)/-(b+Math.Sign(b)*Math.Sqrt(d));
            x2 = c / (a*x1);
            array = new double[] { x1, x2 };
        }
        return array;
    }
}
