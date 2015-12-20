
using System;
using Test1.Enums;
using Test1.Interfaces;

namespace Test1.Engine.Factories
{
    public class WarEffectFactory : IWarEffectFactory
    {
        public WarEffects CreateWarEffect(string warName)
        {
            switch (warName.Trim())
            {
                case "Jihad":
                    return WarEffects.Jihad;
                    break;
                case "Kamikaze":
                    return WarEffects.Kamikaze;
                    break;

                default:
                    throw new ArgumentException("Unrecognized War type.");
            }
        }
    }
}
