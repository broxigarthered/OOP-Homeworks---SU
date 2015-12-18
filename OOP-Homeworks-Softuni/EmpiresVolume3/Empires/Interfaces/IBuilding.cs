using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
    public interface IBuilding
    {
        IList<IUnit> Units { get; }

        IDictionary<ResourceType, int> Resources { get; }

        void Update();

        bool CanProduceResource();

        bool CanProduceUnit();
    }
}
