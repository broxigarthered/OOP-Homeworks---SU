using System.Collections.Generic;
using System.Resources;
using System.Security.Permissions;
using System.Text;
using Empires.Interfaces;

namespace Empires.Models
{
    public abstract class Building : IBuilding
    {
        private IUnit unit;
        private int turnsPerUnit;
        private int turnsPerResource;
        private int totalCounter = 0;
        private int defaultIncrementator = 1;

        public  string UnitType;
        public ResourceType TypeOfResources;
        public int QuantityOfResources;
        public  int UnitsTurns;
        public  int ResourcesTurns;

        //protected Building(IUnit units, IDictionary<ResourceType, int> resurces, int turnsPerUnit, int turnPerResource, ResourceType type, int quantity)
        //{
        //    this.Unit = units;
        //    this.Resources = resurces;
        //    this.ResourceType = type;
        //    this.Quantity = quantity;
        //    this.turnsPerResource = turnPerResource;
        //    this.turnsPerUnit = turnsPerUnit;
        //}

        protected Building(string unitType, ResourceType typeOfResources, int quantityOfResources, int unitsTurns, int resourcesTurn)
        {
            this.UnitType = unitType;
            this.TypeOfResources = typeOfResources;
            this.QuantityOfResources = quantityOfResources;
            this.UnitsTurns = unitsTurns;
            this.ResourcesTurns = resourcesTurn;
        }

        public void TryAddUnits(int turns)
        {
            if (turns % turnsPerUnit == 0 && turns > 0)
            {
                Units.Add(unit);
            }

        }

        
        public int Quantity { get; set; }

        public ResourceType ResourceType { get; set; }

        public void AddResource(int turns)
        {
            if (turns % turnsPerResource == 0)
            {
                if (!Resources.ContainsKey(this.ResourceType))
                {
                    Resources.Add(this.ResourceType, 0);
                }
                Resources[this.ResourceType] += this.Quantity;
            }
           
        }
        public IUnit Unit { get; set; }
        public IList<IUnit> Units { get; }
        public IDictionary<ResourceType, int> Resources { get; set; }



        public void Update()
        {
            totalCounter++;
        }

        public bool CanProduceResource()
        {
            // 15 -> 3
            var canProduce = this.totalCounter > defaultIncrementator &&
                             (this.totalCounter - defaultIncrementator)%this.ResourcesTurns == 0;
           
           
             return canProduce;

        }

        public bool CanProduceUnit()
        {
            var canProduce = this.totalCounter > defaultIncrementator &&
                             (this.totalCounter - defaultIncrementator) % this.UnitsTurns == 0;
            return canProduce;
            
        }


        public override string ToString()
        {
            StringBuilder buildingsOutput = new StringBuilder();
            //TODO FIX LOGIC
            
            int turnsUntilUnit = this.UnitsTurns - (this.totalCounter - defaultIncrementator) % this.UnitsTurns;

            int turnsUntilResource = this.ResourcesTurns - (this.totalCounter - defaultIncrementator) % this.ResourcesTurns;

            buildingsOutput.AppendFormat("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name, // todo might break
                this.totalCounter - defaultIncrementator,
                turnsUntilUnit ,
                this.UnitType,
                turnsUntilResource,
                this.TypeOfResources
                )
                .AppendLine();

            return buildingsOutput.ToString();
        }
    }

}