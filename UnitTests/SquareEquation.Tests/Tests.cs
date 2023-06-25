using Xunit;
using SquareEquationSolver.Services;
//test
namespace SquareEquationSolver.UnitTests.Services
{
    public class SquareEquation_Checker
    {
        [Fact]
        public void SquareEquation_aIs0()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(0, 1, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "a = 0");
        }
        [Fact]
        public void SquareEquation_aIsNaN()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(double.NaN, 1, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "a = NaN");
        }
        [Fact]
        public void SquareEquation_aIsPositiveInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(double.PositiveInfinity, 1, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "a = PositiveInfinity");
        }
        [Fact]
        public void SquareEquation_aIsNegativeInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(double.NegativeInfinity, 1, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "a = NegativeInfinity");
        }
        [Fact]
        public void SquareEquation_bIsNaN()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.NaN, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "b = nan");
        }
        [Fact]
        public void SquareEquation_bIsPositiveInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.PositiveInfinity, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "b = PositiveInfinity");
        }
        [Fact]
        public void SquareEquation_bIsNegativeInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.NegativeInfinity, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "b = NegativeInfinity");
        }
        [Fact]
        public void SquareEquation_cIsNaN()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.NaN, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "c = nan");
        }
        [Fact]
        public void SquareEquation_cIsPositiveInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.PositiveInfinity, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "c = PositiveInfinity");
        }
        [Fact]
        public void SquareEquation_cIsNegativeInf()
        {
            bool result;
            try
            {
                double[] a = SquareEquationSolverService.Solve(1, double.NegativeInfinity, 1);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }
            Assert.False(result, "c = NegativeInfinity");
        }


        [Fact]
        public void SquareEquation_disPositive()
        {
            bool result = true;
            try
            {
                double a = 1;
                double b = 1000000;
                double c = 1;
                double eps = 1e-3;
                double[] q = SquareEquationSolverService.Solve(a, b, c);
                if (b - eps <= -(q[0] + q[1]) && -(q[0] + q[1]) <= b + eps && c - eps <= (q[0] * q[1]) && (q[0] * q[1]) <= c + eps)
                {
                    result = false;
                }
            }
            catch
            {
            }
            Assert.False(result, "D > 0");
        }
        [Fact]
        public void SquareEquation_DisZero()
        {
            bool result = true;
            try
            {
                double a = 1;
                double b = 2;
                double c = 1;
                double eps = 1e-3;
                double[] q = SquareEquationSolverService.Solve(a, b, c);
                if (b - eps <= -(q[0] + q[0]) && -(q[0] + q[0]) <= b + eps && c - eps <= (q[0] * q[0]) && (q[0] * q[0]) <= c + eps)
                {
                    result = false;
                }
            }
            catch
            {
            }
            Assert.False(result, "D = 0");
        }
        [Fact]
        public void SquareEquation_DisNegative()
        {
            bool result = false;
            try
            {
                double a = 1000000;
                double b = 1;
                double c = 1;
                double[] q = SquareEquationSolverService.Solve(a, b, c);
                double p = q[0];
                result = true;
            }
            catch
            {
            }
            Assert.False(result, "D < 0");
        }
    }
}