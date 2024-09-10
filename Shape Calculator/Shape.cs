using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    abstract class Shape
    {
        public double width;
        public double height;

        public abstract double CalculateSurface();

    }
}
