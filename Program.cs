using System;

namespace lab1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double EPS = 0.000001;
            
            Console.WriteLine("Алгоритм Дихотомии:");
            Interval interval = new Interval();
            for (int i = 1; i <= 5; i++)
            {
                interval = Functions.GetInterval(i);
                Console.WriteLine(Dichotomy.dichotomy_calc(interval.A, interval.B, EPS, EPS / 3, i));
            }

            Console.WriteLine();
            Console.WriteLine("Алгоритм Золотого сечения:");
            for (int i = 1; i <= 5; i++)
            {
                interval = Functions.GetInterval(i);
                Console.WriteLine(GoldenSection.goldenSection_calc(interval.A, interval.B, EPS, true, false, 0, 0, i));
            }
            
            Console.WriteLine();
            Console.WriteLine("Алгоритм Фибоначчи:");
            for (int i = 1; i <= 5; i++)
            {
                interval = Functions.GetInterval(i);
                Console.WriteLine(Fibonacci.fibonacci_calc(interval.A, interval.B, 50, 0, 0, 0, 0, true, i));
            }
            
        }
    }
}