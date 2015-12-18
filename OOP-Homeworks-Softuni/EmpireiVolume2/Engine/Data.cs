using System;
using System.Collections;
using System.Collections.Generic;
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Models;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Engine
{
    public class Data
    {
        private IDictionary<string, int> resources = new Dictionary<string, int>();

        private IList<IBuilding> buildings = new List<IBuilding>();

        //private readonly Dictionary<string,int> units = new Dictionary<string, int>();

        public Data()
        {
            // initialize everything so it doesn't blow up (null exceptions and stuff :) )
            this.Buildings = new List<IBuilding>();
            this.Resources = new Dictionary<string, int>();
            this.Units = new Dictionary<string, int>();
            this.InitResources();
        }

        //TODO COULD BE DONE BETTER
        public IDictionary<string, int> Resources
        {
            get { return resources; }
            private set { }
        }

        public IDictionary<string, int> Units { get; }

        //TODO COULD BE DONE BETTER
        public IList<IBuilding> Buildings
        {
            get { return buildings; }
            private set { }
        }


        private void InitResources()
        {
            //TODO COULD BE DONE BETTER
            //since we know which will be the 2 types, simply put them
            this.Resources.Add("Gold",0);
            this.Resources.Add("Steel",0);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            var unitType = unit.GetType().Name;

            if (!this.Units.ContainsKey(unitType))
            {
               this.Units.Add(unitType,0); 
            }

            this.Units[unitType]++;
        }



    }
}
