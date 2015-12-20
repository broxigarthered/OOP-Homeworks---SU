using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Enums;

namespace Test1.Interfaces
{
    public interface IAttackFactory
    {
        AttackTypes CreateWarEffect(string attackName);
    }
}
