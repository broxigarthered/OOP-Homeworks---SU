
using System;
using Test1.Enums;
using Test1.Interfaces;

namespace Test1.Engine.Factories
{
    public class AttackFactory : IAttackFactory
    {
        public AttackTypes CreateWarEffect(string attackName)
        {
            switch (attackName.Trim())
            {
                case "Paris":
                    return AttackTypes.Paris;
                case "SU24":
                    return AttackTypes.SU24;

                default:
                    throw new ArgumentException("Unrecognized attack type");
            }
        }
    }
}
