using System;
using System.Text;
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private int totalTurns = 0;
        private const int Delay = 1;

        protected Building(IUnit unit,
            IResource resource,
            int resourcesRequiredTurns,
            int unitRequiredTurns,
            int resourcesQuantity
            )
        {
            this.Unit = unit;
            this.Resource = resource;
            this.ResourcesRequiredTurns = resourcesRequiredTurns;
            this.UnitRequiredTurns = unitRequiredTurns;
            this.ResourcesQuantity = resourcesQuantity;
        }


        //properties
        public IUnit Unit { get; }

        public IResource Resource { get; }

        public int ResourcesRequiredTurns { get; }

        public int UnitRequiredTurns { get; }

        public int ResourcesQuantity { get; }

        public bool CanProduceResources
        {
            get
            {
                var canProduceResource = this.totalTurns > Delay &&
                                          (this.totalTurns - Delay) % ResourcesRequiredTurns == 0;

                return canProduceResource;
            }
        }

        public bool CanProduceUnits
        {
            get
            {
                var canProduceUnit = totalTurns > Delay &&
                                          (this.totalTurns - Delay) % UnitRequiredTurns == 0;

                var test = UnitRequiredTurns - ((this.totalTurns - Delay) % UnitRequiredTurns);


                return canProduceUnit;
            }
        }


        //Methods

        public void Update()
        {
            totalTurns++;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            int turnsUntilUnit = UnitRequiredTurns - ((this.totalTurns - Delay) % UnitRequiredTurns);
            int turnsUntilResource = ResourcesRequiredTurns - ((this.totalTurns - Delay) % ResourcesRequiredTurns);

            output.AppendFormat($"--{this.GetType().Name}: {this.totalTurns - Delay} turns ({turnsUntilUnit} turns until {this.Unit.Name}, {turnsUntilResource} turns until {this.Resource.Resource})").AppendLine();

            return output.ToString();
        }
    }
}
