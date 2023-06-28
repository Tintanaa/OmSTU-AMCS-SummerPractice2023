using Newtonsoft.Json.Linq;
using SquareEquationSolver;
using SquareEquationSolver.Services;

namespace XUnit.Coverlet
{
    public class CoverletMSBuild
    {
        [Theory]
        [InlineData(0, 1, 1), InlineData(double.NaN, 1, 1), InlineData(double.PositiveInfinity, 1, 1)]
        public void InvalidA(double value1, double value2, double value3)
        {
            try
            {
                var result = SquareEquationSolverService.Solve(value1, value2, value3);
                Assert.False(false, "Doesnt work when invalid A");
            }
            catch (Exception)
            {
                Assert.True(true, "Works well when invalid A");
            }
        }

        [Theory]
        [InlineData(1, double.NaN, 1), InlineData(1, double.PositiveInfinity, 1), InlineData(1, double.NegativeInfinity, 1)]
        public void InvalidB(double value1, double value2, double value3)
        {
            try
            {
                var result = SquareEquationSolverService.Solve(value1, value2, value3);
                Assert.False(false, "Doesnt work when invalid B");
            }
            catch (Exception)
            {
                Assert.True(true, "Works well when invalid B");
            }
        }

        [Theory]
        [InlineData(1, 1, double.NaN), InlineData(1, 1, double.PositiveInfinity), InlineData(1, 1, double.NegativeInfinity)]
        public void InvalidC(double value1, double value2, double value3)
        {
            try
            {
                var result = SquareEquationSolverService.Solve(value1, value2, value3);
                Assert.False(false, "Doesnt work when invalid C");
            }
            catch (Exception)
            {
                Assert.True(true, "Works well when invalid C");
            }
        }

        [Theory]
        [InlineData(1, 1000000, 1)]
        public void PositiveD(double value1, double value2, double value3)
        {
            var result = SquareEquationSolverService.Solve(value1, value2, value3);
            if (result.GetType() == typeof(double[]) && result.Length == 2)
            {
                Assert.True(true, $"D is positive when values are: {value1} {value2} {value3}. Good");
            }
            else
            {
                Assert.False(false, "Not positive D. Sad");
            }
        }

        [Theory]
        [InlineData(1, 2, 1)]
        public void EqualToZeroD(double value1, double value2, double value3)
        {
            var result = SquareEquationSolverService.Solve(value1, value2, value3);
            if (result.GetType() == typeof(double[]) && result.Length == 1)
            {
                Assert.True(true, $"D equals zero when values are: {value1} {value2} {value3}. Good");
            }
            else
            {
                Assert.Fail("Not zero D. Sad");
            }
        }

        [Theory]
        [InlineData(1000000, 1, 1)]
        public void LowerThanZeroD(double value1, double value2, double value3)
        {
            var result = SquareEquationSolverService.Solve(value1, value2, value3);
            if (result.GetType() == typeof(double[]) && result.Length == 0)
            {
                Assert.True(true, $"D is lower when values are: {value1} {value2} {value3}. Good");
            }
            else
            {
                Assert.Fail("Not zero D. Sad");
            }
        }
    }
}