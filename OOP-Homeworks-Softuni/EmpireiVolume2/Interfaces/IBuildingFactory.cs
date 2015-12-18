using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireiVolume2.Interfaces
{
    interface IBuildingFactory
    {
        IBuilding CreateNewBuilding(string input);
    }
}
