using System;

namespace lab1
{
    class Program
    {

        private const int count = 6;
        static void Main(string[] args)
        {
            double EPS = 0.000001;
            Interval interval = new Interval();

            Console.WriteLine("Алгоритм Дихотомии:");            
            for (int i = 1; i <= count; i++)
            {
                if(i == count)
                {
                    Console.WriteLine("TEST MULTIMODAL FUNCTION");
                }
                interval = Functions.GetInterval(i);
                Console.WriteLine(Dichotomy.dichotomy_calc(interval.A, interval.B, EPS, EPS / 3, i));
            }

            Console.WriteLine();
            Console.WriteLine("Алгоритм Золотого сечения:");
            for (int i = 1; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("TEST MULTIMODAL FUNCTION");
                }
                interval = Functions.GetInterval(i);
                Console.WriteLine(GoldenSection.goldenSection_calc(interval.A, interval.B, EPS, true, false, 0, 0, i));
            }

            Console.WriteLine();
            Console.WriteLine("Алгоритм Фибоначчи:");
            for (int i = 1; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("TEST MULTIMODAL FUNCTION");
                }
                interval = Functions.GetInterval(i);
                Console.WriteLine(Fibonacci.fibonacci_calc(interval.A, interval.B, 50, 0, 0, 0, 0, true, i));
            }

            Console.WriteLine();
            Console.WriteLine("Алгоритм Парабол:");
            for (int i = 1; i <= count; i++)
            {
                if (i == count)
                {
                    break;
                    Console.WriteLine("TEST MULTIMODAL FUNCTION");
                }
                interval = Functions.GetInterval(i);
                Console.WriteLine(Parabola.ParabolaCalc(interval.A, 0, interval.B, 0, 0, 0, i, EPS, true));
            }

            Console.WriteLine();
            Console.WriteLine("Алгоритм Брента:");
            for (int i = 1; i <= count; i++)
            {
                if (i == count)
                {
                    break;
                    Console.WriteLine("TEST MULTIMODAL FUNCTION");
                }
                interval = Functions.GetInterval(i);
                Console.WriteLine(Brent.BrentCalc(interval.A, interval.B, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, EPS, i, true));
            }
        }
    }
}