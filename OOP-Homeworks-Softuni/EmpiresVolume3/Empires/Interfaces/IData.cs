
using System.Collections;
using System.Collections.Generic;

namespace Empires.Interfaces
{
    public interface IData
    {
        IDictionary<ResourceType, int> ResourcesData { get; }

        void AddResource(ResourceType type, int quantity);

        IList BuildingsData { get; }

        void AddBuilding(IBuilding building);
        
         IDictionary<string, int> UnitsData { get; }

        void AddUnit(string unitsName);
    }
}
