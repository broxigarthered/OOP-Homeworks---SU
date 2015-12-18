
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Models.Units;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Models.Buildings
{
    public class Archery : Building
    {
        //5 gold -> 3 turns
        //archer  -> 3 turns
        private const int DefaultArcheryResourceQuantity = 5;
        private const int DefaultArcheryResourceTurns = 2;
        private const int DefaultArcheryArcherTurns = 3;

        private static IResource DefaultArcheryResource = new Resources(ResourceType.Gold, DefaultArcheryResourceQuantity);

        private static IUnit DefaultArcherySwordsman = new Archer();

        public Archery()
            : base(DefaultArcherySwordsman,
                  DefaultArcheryResource,
                  DefaultArcheryResourceTurns,
                  DefaultArcheryArcherTurns,
                  "Gold",
                  DefaultArcheryResourceQuantity)
        {
        }
    }
}
