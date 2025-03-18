using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_3
{
    internal class Circle : IShape
    {
        private double _radius = 0;

        public Circle(double radius_)
        { 
            radius = radius_;
        }
        public double radius
        { 
            get => _radius;
            set
            {
                _radius = value > 0 ? value : radius;
            }
        }

        public string type => "Circle";

        public double CalculateArea()
        {
            if (_radius > 0)
            { 
                return 3.14 * (_radius * _radius);
            }

            throw new NotImplementedException("Один из параметров фигуры равен или меньше 0");
        }

        public double CalculatePerimetr()
        {
            if (_radius > 0)
            {
                return 6.28 *_radius;
            }

            throw new NotImplementedException("Один из параметров фигуры равен или меньше 0");
        }
    }
}
