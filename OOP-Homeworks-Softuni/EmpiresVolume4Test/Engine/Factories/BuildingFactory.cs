using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Models.Buildings;

namespace EmpiresVolume3.Engine.Factories
{
   public class BuildingFactory : IBuildingFactory
    {
       public IBuilding CreateBuilding(string name)
       {
           switch (name)
           {
                case "barracks":
                    return new Barracks();
                case "archery":
                    return new Archery();

                default:
                    throw new ArgumentException("Unrecognized building.");
           }
       }
    }
}
