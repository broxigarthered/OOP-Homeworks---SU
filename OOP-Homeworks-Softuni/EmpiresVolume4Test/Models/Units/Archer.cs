
namespace EmpiresVolume3.Models.Units
{
   public class Archer : Unit
   {
       private const int DefaultArcherHealth = 25;
       private const int DefaultArcherDamage = 7;
       private const string ArcherAsString = "Archer";

       public Archer()
            : base(DefaultArcherHealth,
                  DefaultArcherDamage,
                  ArcherAsString)
       {
       }
    }
}
