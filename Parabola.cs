using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public class Parabola
    {
        private static Random rand = new Random();
        public static double ParabolaCalc(double _x1, double _x2, double _x3, double _f1, double _f2, double _f3, int k, double eps, bool isFirst = false)
        {
            double x1 = _x1;
            double x2 = _x2;
            double x3 = _x3;
            double f1 = _f1;
            double f2 = _f2;
            double f3 = _f3;

            if (isFirst)
            {
                double x21 = x1 + Math.Abs(x3-x1) / 3;
                double x22 = x1 + 2* Math.Abs(x3 - x1) / 3;

                f1 = Functions.function(x1, k);
                f3 = Functions.function(x3, k);
                double f21 = Functions.function(x21, k);
                double f22 = Functions.function(x22, k);
                if (f21 < f22)
                {
                    x2 = x21;
                    f2 = f21;
                }
                else {
                    x2 = x22;
                    f2 = f22;
                }
            }

            if (Math.Abs(x3 - x1) < eps)
            {
                return (x1 + x3) / 2;
            }
            double u = x2 - (Math.Pow((x2 - x1), 2.0) * (f2 - f3) - Math.Pow((x2 - x3), 2.0) * (f2 - f1)) / (2 * (x2 - x1) * (f2 - f3) - (x2 - x3) * (f2 - f1));
            double fu = Functions.function(u, k);

            if (u < x2)
            {
                if(fu < f2)
                {
                    return ParabolaCalc(x1, u, x2, f1, fu, f2, k, eps);
                }
                else { return ParabolaCalc(u, x2, x3, fu, f2, f3, k, eps); }
            }
            else
            {
                if (fu > f2)
                {
                    return ParabolaCalc(x1, x2, u, f1, f2, fu, k, eps);
                }
                else { return ParabolaCalc(x2, u, x3, f2, fu, f3, k, eps); }
            }
        }
    }
}
