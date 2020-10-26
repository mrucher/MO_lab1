using System;

namespace lab1
{
    public class Interval
    {
        private double a, b;

        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }
    }

    public class Functions
    {
        public static double function(double x, int k)
        {
            switch (k)
            {
                case 1:
                    return -1 * Math.Pow(x, 5) + 4 * Math.Pow(x, 4) - 12 * Math.Pow(x, 3) + 11 * Math.Pow(x, 2) -
                           2 * x + 1;
                case 2:
                    return Math.Log10(x - 2) + Math.Pow(Math.Log10(10 - x), 2) - Math.Pow(x, 0.2);
                case 3:
                    return -3 * x * Math.Sin(0.75 * x) + Math.Exp(-2 * x);
                case 4:
                    return Math.Exp(3 * x) + 5 * Math.Exp(-2 * x);
                case 5:
                    return 0.2 * x * Math.Log10(x) + Math.Pow(x - 2.3, 2);
                default:
                    return 0;
                    break;
            }
        }

        public static Interval GetInterval(int k)
        {
            Interval interval = new Interval();
            switch (k)
            {
                case 1:
                    interval.A = -0.5;
                    interval.B = 0.5;
                    break;
                case 2:
                    interval.A = 6;
                    interval.B = 9.9;
                    break;
                case 3:
                    interval.A = 0;
                    interval.B = 2 * Math.PI;
                    break;
                case 4:
                    interval.A = 0;
                    interval.B = 1;
                    break;
                case 5:
                    interval.A = 0.5;
                    interval.B = 2.5;
                    break;
                default:
                    break;
            }

            return interval;
        }
    }
}