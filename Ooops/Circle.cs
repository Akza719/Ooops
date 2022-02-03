using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    internal class Circle : Dimension_Shape
    {
        private double _radius;
        public Circle(string color,double radius):base(color)
        {
            this._radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
                
                
                
         }
    }
}
