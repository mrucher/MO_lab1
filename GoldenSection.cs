namespace lab1
{
    public class GoldenSection
    {
        public double goldenSection_calc(double a, double b, double eps, bool isFirst, bool isMoveLeft, double f_old,
            double x_old,
            int n)
        {
            if (b - a < eps)
            {
                return (a + 2) / 2;
            }

            if (isFirst)
            {
                double x1 = a + 0.381966011 * (b - a);
                double x2 = b - 0.381966011 * (b - a);

                double f1 = Functions.function(x1, n);
                double f2 = Functions.function(x2, n);

                if (f1 >= f2)
                {
                    return goldenSection_calc(x1, b, eps, false, false, f2, x2,n);
                }
                else
                {
                    return goldenSection_calc(a, x2, eps, false, true, f1, x1, n);
                }
            }
            else
            {
                double x, f;
                if (isMoveLeft)
                {
                    x = a + 0.381966011 * (b - a);
                    f = Functions.function(x, n);

                    if (f >= f_old)
                    {
                        return goldenSection_calc(x, b, eps, false, false, f_old, x_old, n);
                    }
                    else
                    {
                        return goldenSection_calc(a, x_old, eps, false, true, f, x, n);
                    }
                }
                else
                {
                    x = b - b - 0.381966011 * (b - a);
                    f = Functions.function(x, n);

                    if (f_old >= f)
                    {
                        return goldenSection_calc(x_old, b, eps, false, false, f, x, n);
                    }
                    else
                    {
                        return goldenSection_calc(a, x, eps, false, true, f_old, x_old, n);
                    }
                }
            }
        }
    }
}