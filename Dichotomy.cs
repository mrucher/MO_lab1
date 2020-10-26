namespace lab1
{
    public class Dichotomy
    {
        //delta = eps/3
        
        public double dichotomy_calc(double a, double b, double eps, double delta, int n)
        {
            if (a - b < eps)
            {
                return (a + b) / 2;
            }

            double x1 = (a + b) / 2 - delta;
            double x2 = (a + b) / 2 + delta;

            double f1 = Functions.function(x1, n);
            double f2 = Functions.function(x2, n);

            if (f1 < f2)
            {
                return dichotomy_calc(a, x2, eps, delta, n);
            }
            else if (f1 > f2)
            {
                return dichotomy_calc(x1, b, eps, delta, n);
            }
            else
            {
                return dichotomy_calc(x1, x2, eps, delta, n);
            }
        }
    }
}