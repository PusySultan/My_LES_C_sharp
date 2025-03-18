using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_3
{
    internal class Traingle : IShape
    {
        private double _a = 0;
        private double _b = 0;
        private double _c = 0;

        private float _alpha = 0;
        private float _beta = 0;
        private float _gamma = 0;

        public Traingle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (!CheckedRules(a, b, c))
                {
                    throw new NotImplementedException("Не корректные данные");
                }
                _a = a;
                _b = b;
                _c = c;

                _alpha = (float)Math.Acos(
                    ((_a * Math.Pow(_c, 2)) - (_a * Math.Pow(_b, 2)) + (_b * Math.Pow(_c, 2))) /
                    (2 * _a * _b * Math.Pow(_c, 2)));

                _beta = (float)Math.Acos(
                    ((_a * Math.Pow(_b, 2)) - (_a * Math.Pow(_c, 2)) + (_b * Math.Pow(_c, 2))) /
                    (2 * _a * _c * Math.Pow(_b, 2)));

                _gamma = (float)Math.Acos(
                    ((_a * Math.Pow(_b, 2)) - (_b * Math.Pow(_c, 2)) + (_a * Math.Pow(_c, 2))) /
                    (2 * _b * _c * Math.Pow(_a, 2)));
            }
            else 
            { 
                throw new NotImplementedException("Один из параметров фигуры равен или меньше 0");
            }

           
        }

        public string type => "Traingle";

        public double CalculateArea()
        {           
            return 0.5 * _a * _b * Math.Sin(_alpha);
        }

        public double CalculatePerimetr()
        {
           return _a + _b + _c;
        }

        private bool CheckedRules(double a, double b, double c)
        {
            if (a + b < c ||
                a + c < b ||
                b + c < a)
            {
                return false;
            }

            return true;
        }
    }
}
