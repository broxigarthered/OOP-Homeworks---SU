using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateArea()
        {
            return Math.PI*(this.Radius*this.Radius);
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*this.Radius;
        }
    }
}
