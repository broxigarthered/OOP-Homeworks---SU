
using Test1.Enums;

namespace Test1.Interfaces
{
    public interface IWarEffectFactory
    {
        WarEffects CreateWarEffect(string warName);
    }
}
