using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //read the whole line in format -> x,y,z
            Console.WriteLine("X:  Y:  Z:");
            string line = Console.ReadLine();
            string[] tokens = line.Split(' ');
            double x = Double.Parse(tokens[0]);
            double y = Double.Parse(tokens[1]);
            double z = Double.Parse(tokens[2]);

            line = Console.ReadLine();
            tokens = line.Split(' ');
            double x1 = Double.Parse(tokens[0]);
            double y1 = Double.Parse(tokens[1]);
            double z1 = Double.Parse(tokens[2]);

            DistanceCalculator d1 = new DistanceCalculator(x,y,z);
            DistanceCalculator d2 = new DistanceCalculator(x1,y1,z1);

            Console.WriteLine("The distance between both points is {0}",
                Distance(d1,d2));
        }

        public static double Distance(DistanceCalculator d1, DistanceCalculator d2)
        {
            double axisXDistance = d1.X - d2.X;
            double axisYDistance = d1.Y - d2.Y;
            double axisZDistance = d1.Z - d2.Z;
            return Math.Sqrt((axisXDistance * axisXDistance) + (axisYDistance * axisYDistance) + (axisZDistance * axisZDistance));
        }
    }

    public class DistanceCalculator
    {

        //fields
        public double x;
        public double y;
        public double z;
        

        public DistanceCalculator(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            
        }
        //properties
        public double X
        {
            get { return this.x; }

            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

}
}
