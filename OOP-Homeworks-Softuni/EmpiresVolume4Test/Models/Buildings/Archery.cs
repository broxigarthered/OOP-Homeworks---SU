
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Models.Units;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Models.Buildings
{
    public class Archery : Building
    {
        static IUnit unit = new Archer();
        static IResource resource = new Resources(ResourceType.Gold, 5);
        private const int resourcesRequiredTurns = 2;
        private const int unitRequiredTurns = 3;
        private const int resourcesQuantity = 5;

        public Archery() 
            : base(unit,
                  resource,
                  resourcesRequiredTurns,
                  unitRequiredTurns,
                  resourcesQuantity)
        {
        }
    }
}
