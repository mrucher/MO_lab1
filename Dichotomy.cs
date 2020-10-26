namespace lab1
{
    public class Dichotomy
    {
        //delta = eps/3

        double function(double x)
        {
            return 2 * x;
        }

        public double dichotomy_calc(double a, double b, double eps, double delta)
        {
            if (a - b < eps)
            {
                return (a + b) / 2;
            }

            double x1 = (a + b) / 2 - delta;
            double x2 = (a + b) / 2 + delta;

            double f1 = function(x1);
            double f2 = function(x2);

            if (f1 < f2)
            {
                return dichotomy_calc(a, x2, eps, delta);
            }
            else if (f1 > f2)
            {
                return dichotomy_calc(x1, b, eps, delta);
            }
            else
            {
                return dichotomy_calc(x1, x2, eps, delta);
            }
        }
    }
}