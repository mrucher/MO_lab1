using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public class Brent
    {
        //x наименьшее значение функции
        //w 2-е снизу значение ф-и
        //v предыдущее значение w

        private static readonly double k = (3 - Math.Sqrt(5)) / 2;
        public static double BrentCalc(double a, double c, double x, double w, double v, double d, double e, double fa, double fc, double fx, double fw, double fv, double EPS, int i, bool isFirst = false)
        {
            if (isFirst)
            {
                x = w = v = (a + c) / 2;
                fx = fw = fv = Functions.function(x, i);
                d = c - a;
                e = c - a;
            }

            if (Math.Abs(c - a) < EPS)
            {
                return (c + a) / 2;
            }

            /*            if (Math.Max(Math.Abs(x - a), Math.Abs(c - x)) < EPS)
                        {
                            return x;
                        }*/
            double fu;
            double g;
            double u;
            g = e;
            e = d;

            if (x != w && x != v && fx != fw && fx != fv)
            {
                if (x > w && x < v)
                {
                    u = x - (Math.Pow((x - w), 2.0) * (fx - fv) - Math.Pow((x - v), 2.0) * (fx - fw)) / (2 * (x - w) * (fx - fv) - (x - fv) * (fx - fw));
                }
                else
                {
                    u = x - (Math.Pow((x - v), 2.0) * (fx - fw) - Math.Pow((x - w), 2.0) * (fx - fv)) / (2 * (x - v) * (fx - fw) - (x - fw) * (fx - fv));
                }
                if (u >= a + EPS && u <= c - EPS && Math.Abs(u - x) < g / 2)
                {
                    d = Math.Abs(u - x);
                }
            }
            else
            {
                if (x < (c + a) / 2)
                {
                    u = x + k * (c - x);
                    d = c - x;
                }
                else
                {
                    u = x - k * (x - a);
                    d = x - a;
                }
                if (Math.Abs(u - x) < EPS)
                {
                    u = x + Math.Sign(u - x) * EPS;
                }
            }
            fu = Functions.function(u, i);
            if (fu < fx)
            {
                if (u >= x) { 
                    a = x;
                    fa = fx;
                }
                else {
                    c = x;
                    fc = fx;
                }
                v = w;
                w = x;
                x = u;
                fv = fw;
                fw = fx;
                fx = fu;
            }
            else
            {
                if (u >= x) { 
                    c = u;
                    fc = fu;
                }
                else { 
                    a = u;
                    fa = fu;
                }
                if (fu <= fw || w == x)
                {
                    v = w;
                    w = u;
                    fv = fw;
                    fw = fu;
                }
                else if (fu <= fv || v == x || v == w)
                {
                    v = u;
                    fv = fu;
                }
            }
            return BrentCalc(a, c, x, w, v, d, e, fa, fc, fx, fw, fv, EPS, i);
        }
    }
}
