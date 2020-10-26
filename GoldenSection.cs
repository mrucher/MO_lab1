using System;

namespace lab1
{
    public class GoldenSection
    {
        public static double goldenSection_calc(double a, double b, double eps, bool isFirst, bool isMoveLeft, double f_old,
            double x_old,
            int k)
        {
            if (Math.Abs(b - a) < eps)
            {
                return (a + b) / 2;
            }

            if (isFirst)
            {
                double x1 = a + 0.381966011 * (b - a);
                double x2 = b - 0.381966011 * (b - a);
                
                double f1 = Functions.function(x1, k);
                double f2 = Functions.function(x2, k);
                

                if (f1 >= f2)
                {
                    return goldenSection_calc(x1, b, eps, false, false, f2, x2,k);
                }
                else
                {
                    return goldenSection_calc(a, x2, eps, false, true, f1, x1, k);
                }
            }
            else
            {
                
                double x, f;
                if (isMoveLeft)
                {
                    x = a + 0.381966011 * (b - a);
                    f = Functions.function(x, k);

                    if (f >= f_old)
                    {
                        return goldenSection_calc(x, b, eps, false, false, f_old, x_old, k);
                    }
                    else
                    {
                        return goldenSection_calc(a, x_old, eps, false, true, f, x, k);
                    }
                }
                else
                {
                    x = b - 0.381966011 * (b - a);
                    f = Functions.function(x, k);

                    if (f_old >= f)
                    {
                        return goldenSection_calc(x_old, b, eps, false, false, f, x, k);
                    }
                    else
                    {
                        return goldenSection_calc(a, x, eps, false, true, f_old, x_old, k);
                    }
                }
            }
        }
    }
}