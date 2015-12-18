
using System;
using Empires.Interfaces;
using Empires.Models;

namespace Empires.MyLogic
{
    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType)
        {
            switch (buildingType)
            {
                case "barracks":
                    return  new Barracks();
                case "archery":
                    return new Archery();

                default:
                    throw new ArgumentException("The Factory cannot recognize the building type.");
            }
        }   
    }
}
