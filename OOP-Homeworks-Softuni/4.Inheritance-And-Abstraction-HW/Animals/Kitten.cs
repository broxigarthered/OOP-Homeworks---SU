using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        public void ProduceSound()
        {
            Console.WriteLine("Myauu.. the hell am I doing?");
        }

        public Kitten(string name, int age, string gender = "female")
            : base(name, age, gender)
        {
        }
    }
}
