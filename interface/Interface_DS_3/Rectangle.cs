using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_3
{
    internal class Rectangle : IShape
    {
        private double _width = 0;  // ширина
        private double _height = 0; // Высота

        public Rectangle(double width_, double height_)
        { 
            width = width_;
            height = height_;
        }

        public string type => "Rectangle";
        public double width
        { 
            get => _width;
            set
            { 
                _width = value > 0 ? value : _width;
            }
        }

        public double height
        {
            get => _height;
            set
            {
                _height = value > 0 ? value : _height;
            }
        }
        public double CalculateArea()
        {
            if (_height > 0 && _width > 0)
            {
                return _width * _height;
            }

            throw new NotImplementedException("Один из параметров фигуры равен или меньше 0");
        }

        public double CalculatePerimetr()
        {
            if (_height > 0 && _width > 0)
            {
                return ((2 * _width) + (2 * _height));
            }

            throw new NotImplementedException("Один из параметров фигуры равен или меньше 0");
        }
    }
}
