using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class test
    {
        static void Main(string[] args)
        {

            List<IShape> shapes = new List<IShape>
            {
                new Rhombus(15, 22),
                new Rectangle(25,33),
                new Circle(10),
                new Rhombus(20,15),
                new Rectangle(3,7),
                new Circle(4)
            };

            foreach (var v in shapes)
            {
                Console.WriteLine(string.Format("{0}, Surface -> {1:F2}, Perimeter {2:F2}",
                    v.GetType().Name,
                    v.CalculateArea(),
                    v.CalculatePerimeter()));

            }

        }
    }
}
