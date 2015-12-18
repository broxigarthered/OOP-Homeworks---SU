using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Models.Buildings;

namespace EmpireiVolume2.Engine.Factories
{
    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateNewBuilding(string input)
        {
            switch (input)
            {
                case "archery":
                    return new Archery();
                case "barracks":
                    return new Barracks();

                    //TODO create custom errors
                default:
                    throw new ArgumentException("Building type - wrong.");
            }
        }

    }
}
