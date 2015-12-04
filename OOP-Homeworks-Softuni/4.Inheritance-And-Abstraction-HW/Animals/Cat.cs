using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat :  Animal, ISoundProducible
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            throw new NotImplementedException();
        }
    }
}
