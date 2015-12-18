using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models
{
   public class Archer:Unit
    {
       
       private const int ArcherHealth = 25;
       private const int ArcherDamage = 7;
        public Archer()
            : base(ArcherHealth, ArcherDamage)
       {
       }
    }
}
