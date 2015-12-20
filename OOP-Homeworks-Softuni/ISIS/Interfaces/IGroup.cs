
using Test1.Enums;

namespace Test1.Interfaces
{
    public interface IGroup 
    {
        string Name { get; }

        int Health { get; set; }
        
        int InitialHealth { get; set; }

        int Damage { get; }

        

        WarEffects WarEffect { get; }

        AttackTypes GroupAttackType { get; }

        bool TriggerWarEffect { get; set; }

        bool IsEffectTriggered { get; set; }

        


        void ApplyWarEffect();

        void Attack(IGroup targetGroup);

        void Update();

        void CheckIfEffectShouldBeTriggered();

        void CheckIfEffectShouldBeTriggeredTarget(IGroup targetGroup);
    }
}
