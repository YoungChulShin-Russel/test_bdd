using System;

namespace BDDTest
{
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }

    public class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        
        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Div(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }

            return x / y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }
    }
}
