using System.Collections.Generic;
using Empires.Interfaces;

namespace Empires.Models
{
    public class Archery : Building
    {
        //produces 5 gold (every 2 turns) and an archer (every 3 turns)
        private const ResourceType resourceType = ResourceType.Gold;
        private const int Quantaty = 5;
        private const int TurnsPerUnit = 3;
        private const int TurnsPerResource = 2;
        private const string unitTypeString = "Archer";

        //public Archery(IUnit units, IDictionary<ResourceType, int> resurces)
        //    : base(units, resurces, TurnsPerUnit,TurnsPerResource, resourceType, Quantaty)
        //{
        //}

        //string unitType, ResourceType typeOfResources, int quantityOfResources, int unitsTurns, int resourcesTurn
        public Archery()
            : base(unitTypeString,resourceType,Quantaty,TurnsPerUnit,TurnsPerResource)
        {
            
        }
    }
}