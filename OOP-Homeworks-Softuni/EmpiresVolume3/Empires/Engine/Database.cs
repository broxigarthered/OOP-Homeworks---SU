using System.Collections.Generic;
using Empires.Interfaces;

namespace Empires.Models
{
    public class Database : IDatabase
    {

        public Database (IDictionary<ResourceType, int> resource, IList<IBuilding> buildings )
        {
            this.Resource = resource;
            this.Buildings = buildings;
        }

        public IDictionary<ResourceType, int> Resource { get; private set; }
        public IList<IBuilding> Buildings { get; private set; }
    }
}