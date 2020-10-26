using System;

namespace lab1
{
    public class Fibonacci
    {
        double fib(int n)
        {
            return 1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n));
        }
        public double fibonacci_calc(double a, double b, int n, double x1, double x2, double f1, double f2, bool isFirst, int k)
        {
            if (n == 1)
            {
                return (x1 + x2) / 2;
            }
            if (isFirst)
            {
                double _x1 = a + (b - a) * (fib(n - 2) / fib(n));
                double _x2 = a + (b - a) * (fib(n - 1) / fib(n));
                double _f1 = Functions.function(_x1, k);
                double _f2 = Functions.function(_x2, k);

                return fibonacci_calc(a, b, n, _x1, _x2, _f1, _f2, false, k);
            }
            else
            {
                n--;
                if (f1 > f2)
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                    f1 = f2;
                    f2 = Functions.function(x2, k);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                    f2 = f1;
                    f1 = Functions.function(x1, k);
                }
                return fibonacci_calc(a, b, n, x1, x2, f1, f2, false, k);
            }
        }
    }
}