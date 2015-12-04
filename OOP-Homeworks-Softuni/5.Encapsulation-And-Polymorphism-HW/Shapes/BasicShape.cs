using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape : IShape
    {
        protected double width;
        protected double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
