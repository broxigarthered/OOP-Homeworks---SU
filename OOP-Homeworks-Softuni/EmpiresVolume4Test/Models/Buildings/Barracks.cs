
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Models.Units;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Models.Buildings
{
    public class Barracks : Building
    {
        static IUnit unit = new Swordsman();
        static IResource resource = new Resources(ResourceType.Steel, 10);
        private const int resourcesRequiredTurns = 3;
        private const int unitRequiredTurns = 4;
        private const int resourcesQuantity = 10;

        public Barracks() :
            base(unit,
                resource,
                resourcesRequiredTurns,
                unitRequiredTurns,
                resourcesQuantity)
        {
        }
    }
}
