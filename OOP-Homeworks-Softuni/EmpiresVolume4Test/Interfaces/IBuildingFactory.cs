using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiresVolume3.Interfaces
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string name);
    }
}
