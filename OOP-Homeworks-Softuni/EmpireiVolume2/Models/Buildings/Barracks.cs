
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Models.Units;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Models.Buildings
{
    class Barracks : Building
    {
        //⦁	Barracks - produces 10 steel (every 3 turns) and a swordsman (every 4 turns)

        private const int DefaultBarracksResourceQuantity = 10;
        private const int DefaultBarracksResourceTurns = 3;
        private const int DefaultBarracksSwordmanTurns = 4;


        private static IResource DefaultBarracksResource = new Resources(ResourceType.Steel, DefaultBarracksResourceQuantity);

        private static IUnit DefaultBarracksSwordsman = new Swordsman();


        public Barracks()
            : base(DefaultBarracksSwordsman,
                  DefaultBarracksResource,
                  DefaultBarracksResourceTurns,
                  DefaultBarracksSwordmanTurns,
                  "Steel",
                  DefaultBarracksResourceQuantity)
        {
        }
    }
}
