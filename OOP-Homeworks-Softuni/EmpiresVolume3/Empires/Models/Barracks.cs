using System.Collections.Generic;
using Empires.Interfaces;

namespace Empires.Models
{
    public class Barracks : Building
    {
        //produces 10 steel (every 3 turns) and a swordsman (every 4 turns) 
        private const ResourceType resourceType = ResourceType.Steel;
        private const int Quantaty = 10;
        private const int TurnsPerUnit = 4;
        private const int TurnsPerResources = 3;
        private const string BarracksSwordsMan = "Swordsman";

        //public Barracks(IUnit units, IDictionary<ResourceType, int> resurces)
        //    : base(units, resurces, TurnsPerUnit, TurnsPerResources, resourceType, Quantaty)
        //{
        //}

        public Barracks()
            : base(BarracksSwordsMan, resourceType,
                  Quantaty,
                  TurnsPerUnit,
                  TurnsPerResources)
        {

        }
    }
}