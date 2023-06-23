namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        if (a == 0 || new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
        {
            throw new ArgumentException("Ошибка");
        }
        double x1;
        double x2;
        double[] array = new double[2];
        //double d = b * b - 4 * a * c;
        double d = (b - 2 * Math.Sqrt(a * c)) * (b + 2 * Math.Sqrt(a * c));
        int dcon = Convert.ToInt32(d);
        double eps = Math.Abs(dcon - d);
        if (d<0 && !(-Single.Epsilon < d && d < 0))
        {
            array = new double[0];
        }
        if (d == 0|| d < Single.Epsilon)
        {
            x1 = 2*c/-b;
            array = new double[] { x1 };
        }
        if(d>0|| d >= Single.Epsilon)
        {
            //x1 = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
            x1 = (2*c)/-(b+Math.Sign(b)*Math.Sqrt(d));
            x2 = c / a*x1;
            array = new double[] { x1, x2 };
        }
        return array;
    }
}
