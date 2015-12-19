using System.Collections;
using System.Collections.Generic;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Interfaces
{
    public interface IData
    {
        IDictionary<ResourceType, int> Treasury { get; }

        IList<IBuilding> Buildings { get; }

        IDictionary<string, int> Units { get; }

        //methods

        void AddBuilding(IBuilding building);

        void AddUnit(string name);

        void InitTreasury();
    }
}
