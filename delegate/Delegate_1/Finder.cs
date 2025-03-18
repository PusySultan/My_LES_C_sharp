using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegate_1
{

    internal class Finder
    {
        private static Dictionary<Regex, Func<(double, double), double>> _func = 
        new Dictionary<Regex, Func<(double, double), double>>()
        {
            { new Regex(@".*\+.*"), Adder() },
            { new Regex(@".*-.*"), Minus() },
            { new Regex(@".*\*.*"), Multiplex() },
            { new Regex(@".*/.*"), Divider() },
        };

        private static Func<(double, double), double> Divider()
        {
            return ((double a, double b) tuple) => tuple.b != 0 ? tuple.a / tuple.b 
                                                                : throw new Exception();
        }

        private static Func<(double, double), double> Multiplex()
        {
            return ((double a, double b) tuple) => tuple.a * tuple.b;
        }

        private static Func<(double, double), double> Minus()
        {
            return ((double a, double b) tuple) => tuple.a - tuple.b;
        }

        private static Func<(double, double), double> Adder()
        {
            return ((double a, double b) tuple) => tuple.a + tuple.b;
        }

        public static double Resulte(string line)
        {

            foreach (var item in _func)
            {
                if (item.Key.IsMatch(line))
                {
                   return item.Value(Parser(line));
                }
            }

            throw new Exception();
        }

        private static (double a, double b) Parser(string line)
        {
            var res = line.Split('+', '-', '*', '/');
            double  a = double.Parse(res[0]);
            double b = double.Parse(res[1]);

            return (a, b);
        }
    }
}