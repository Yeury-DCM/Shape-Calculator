using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    class Circle : Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            this.width = radius;
            this.height = radius;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * Math.Pow(radius, 2);
            return Math.Round(surface, 2);
        }
    }
}
