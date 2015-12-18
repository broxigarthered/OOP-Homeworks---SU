
using System.Text;
using EmpireiVolume2.Engine;
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Models
{
    public abstract class Building : IBuilding
    {

        private int cyclesCount = 0;

        private int turnsUntilUnit;
        private int turnsUntilResource;

        private int resourceRequiredTurns;
        private int unitRequiredTurns;

        private string currentType;
        private int resourceQuantity;
     
        private const int DefaultTurnsDelay = 1;



        protected Building(IUnit unit, IResource resource, int resourceLength, int unitLength,string resourceType,int quantity)
        {
            this.Unit = unit;
            this.Resource = resource;
            this.ResourceRequiredTurns = resourceLength;
            this.UnitRequiredTurns = unitLength;
            this.CurrentType = resourceType;
            this.ResourceQuantity = quantity;
        }

        public string CurrentType
        {
            get { return currentType; }
            set { currentType = value; }
        }

        public int ResourceQuantity
        {
            get { return resourceQuantity; }
            set { resourceQuantity = value; }
        }

        public int ResourceRequiredTurns
        {
            get { return this.resourceRequiredTurns; }
            set { this.resourceRequiredTurns = value; }
        }

        public int UnitRequiredTurns
        {
            get { return unitRequiredTurns; }
            set { unitRequiredTurns = value; }
        }


        public IUnit Unit { get; }

        public IResource Resource { get; }
        public int TotalTurnsPlayed { get; }



        //checks if the building is able to produce resources/units at the current turn
        //when it returns true it tells the engine to produce recources/units
        public bool CanProduceResource
        {
            get
            {
                //E.G
                // cycles count(current turn) = 11
                // defaultTurnsDelay = 1
                // resourceRequiredTurns = 2

                //Logic
                // cyclesCount > defaultTurnsDelay -> 11 > 1?  - YES
                // cyclesCount - DefaultTurnsDelay % requiredTurns -> 10 - 1 % 2 == 0  - YES => return true

                bool canProduceResource = this.cyclesCount > DefaultTurnsDelay && (this.cyclesCount - DefaultTurnsDelay) % this.resourceRequiredTurns == 0;
                return canProduceResource;
            }
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cyclesCount > DefaultTurnsDelay && (this.cyclesCount - DefaultTurnsDelay) % this.unitRequiredTurns == 0;
                return canProduceUnit;
            }
        }



        public void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
    
            //15 % 4
            // The same logic, like in the boolean operators.
            int turnsUntilUnit = this.unitRequiredTurns-(this.cyclesCount - DefaultTurnsDelay) % this.unitRequiredTurns;

            int turnsUntilResource = this.resourceRequiredTurns - (this.cyclesCount - DefaultTurnsDelay) % this.resourceRequiredTurns;


            sb.AppendLine()
                .AppendFormat("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                    this.GetType().Name,
                    this.cyclesCount - DefaultTurnsDelay,
                    turnsUntilUnit,
                    this.Unit.GetType().Name,
                    turnsUntilResource,
                    this.CurrentType
                );
                
            return sb.ToString();
        }
    }
}
