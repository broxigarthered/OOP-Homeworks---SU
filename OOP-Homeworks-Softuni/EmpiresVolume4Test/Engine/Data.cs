using System;
using System.Collections.Generic;
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Engine
{
    public class Data : IData
    {
        //Constructor
        public Data()
        {
            this.Treasury = new Dictionary<ResourceType, int>();
            this.Buildings = new List<IBuilding>();
            this.Units = new Dictionary<string, int>();
            this.InitTreasury();
        }


        //Properties
        public IDictionary<ResourceType, int> Treasury { get; }

        public IList<IBuilding> Buildings { get; }

        public IDictionary<string, int> Units { get; }

        


        //METHODS

        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException("Building cannot be null.");
            }

            this.Buildings.Add(building);
        }

        public void AddUnit(string name)
        {
            if (!this.Units.ContainsKey(name))
            {
                this.Units.Add(name,0);
            }

            this.Units[name]++;
        }

        public void InitTreasury()
        {
            this.Treasury.Add(ResourceType.Gold,0);
            this.Treasury.Add(ResourceType.Steel,0);
        }
    }
}
