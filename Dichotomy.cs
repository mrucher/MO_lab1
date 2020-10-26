using System;

namespace lab1
{
    public class Dichotomy
    {
        //delta = eps/3
        
        public static double dichotomy_calc(double a, double b, double eps, double delta, int k)
        {
            if (Math.Abs(a - b) < eps)
            {
                return (a + b) / 2;
            }

            double x1 = (a + b) / 2 - delta;
            double x2 = (a + b) / 2 + delta;

            double f1 = Functions.function(x1, k);
            double f2 = Functions.function(x2, k);
            

            if (f1 < f2)
            {
                return dichotomy_calc(a, x2, eps, delta, k);
            }
            else if (f1 > f2)
            {
                return dichotomy_calc(x1, b, eps, delta, k);
            }
            else
            {
                return dichotomy_calc(x1, x2, eps, delta, k);
            }
        }
    }
}