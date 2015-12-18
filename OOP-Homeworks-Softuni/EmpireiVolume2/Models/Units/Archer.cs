
using System.Runtime.Serialization;

namespace EmpireiVolume2.Models.Units
{
    public class Archer : Unit
    {
        private const int DefaultArcherHealth = 25;
        private const int DefaultArcherDamage = 7;


        public Archer()
            : base(DefaultArcherDamage, DefaultArcherHealth)
        {
        }
    }
}
