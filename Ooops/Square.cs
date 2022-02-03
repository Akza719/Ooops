using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    class Square:Dimension_Shape
    {
        private double _sideLength;
        public Square(string color,double sideLength):base(color)
        {
            _sideLength = sideLength;
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
