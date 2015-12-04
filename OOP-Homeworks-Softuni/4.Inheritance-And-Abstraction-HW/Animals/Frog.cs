using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Gwlrlrlrlrl, I'm MURLOC!!");
        }
    }
}
