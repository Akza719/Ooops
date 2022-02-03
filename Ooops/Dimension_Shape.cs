using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
   public abstract  class Dimension_Shape
    {
        protected string color;
        public Dimension_Shape(string color )
        {
            this.color = color;

        }
        public string GetColour()
        {
            return color;
        }
        public abstract double GetArea();
    }
}
