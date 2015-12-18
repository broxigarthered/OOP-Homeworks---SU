

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Empires.Interfaces;

namespace Empires.MyLogic
{
    public class Data : IData
    {
        public Data()
        {
            this.ResourcesData = new Dictionary<ResourceType, int>();
            this.BuildingsData = new List<IBuilding>();
            this.UnitsData = new Dictionary<string, int>();
            this.InitResource();

        }


        public IDictionary<ResourceType, int> ResourcesData { get; }

        public void AddResource(ResourceType type, int quantity)
        {
            if (!ResourcesData.ContainsKey(type))
            {
                ResourcesData.Add(type,0);
            }

            this.ResourcesData[type] += quantity;
        }

        private void InitResource()
        {
            this.ResourcesData.Add(ResourceType.Gold,0);
            this.ResourcesData.Add(ResourceType.Steel,0);
        }



        public IList BuildingsData { get; }

        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException("The building cannot be null - BuildingsData");
            }

            this.BuildingsData.Add(building);
        }




        public IDictionary<string, int> UnitsData { get; }

        public void AddUnit(string unitsName)
        {
            if (!UnitsData.ContainsKey(unitsName))
            {
                this.UnitsData.Add(unitsName,0);
            }

            this.UnitsData[unitsName]+=1;
        }
    }
}
