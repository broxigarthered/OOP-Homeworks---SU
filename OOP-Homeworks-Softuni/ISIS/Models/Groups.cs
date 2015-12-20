
using System;
using System.Text;
using Test1.Enums;
using Test1.Interfaces;

namespace Test1.Models
{
    public class Groups : IGroup
    {
        private int health;
        private int damage;
        private int initialHealth;
        private int initialDamage;
        private const int defaultDamageBooster = 2;
        private const int defaultKamikazeBooster = 50;

        private bool isEffectTriggered;
        private bool triggerWarEffect;




        public Groups(string name, int health, int damage, WarEffects warEffect, AttackTypes groupAttackType)
        {
            this.Name = name;
            this.Health = health;

            this.Damage = damage;
            this.WarEffect = warEffect;
            this.GroupAttackType = groupAttackType;

            this.InitialHealth = Health;
            this.initialDamage = damage;
        }


        public string Name { get; }

        public int Health
        {
            get
            {
                if (this.health < 0)
                {
                    this.health = 0;
                }
                return this.health;
            }
            set { this.health = value; }
        }

        public int Damage
        {
            get
            {
                if (this.damage <= this.initialDamage)
                {
                    this.damage = initialDamage;
                }

                return this.damage;
            }
            set { this.damage = value; }
        }

        public WarEffects WarEffect { get; }

        public AttackTypes GroupAttackType { get; }

        public bool TriggerWarEffect
        {
            get { return this.triggerWarEffect; }

            set { this.triggerWarEffect = value; }

        }

        public bool IsEffectTriggered
        {
            get { return this.isEffectTriggered; }
            set { this.isEffectTriggered = value; }
        }


        public int InitialHealth
        {
            get { return this.initialHealth; }
            set { this.initialHealth = value; }
        }


        //METHODS
        

        public void ApplyWarEffect()
        {
            switch (this.WarEffect)
            {
                case WarEffects.Jihad:
                    this.Damage *= defaultDamageBooster;
                    this.IsEffectTriggered = true;
                    break;

                case WarEffects.Kamikaze:
                    this.Health += defaultKamikazeBooster;
                    this.IsEffectTriggered = true;
                    break;
            }
        }

        public void Attack(IGroup targetGroup)
        {
            switch (this.GroupAttackType)
            {
                case AttackTypes.Paris:
                 
                    targetGroup.Health -= this.Damage;
                    CheckIfEffectShouldBeTriggeredTarget(targetGroup);
                    break;

                case AttackTypes.SU24:

                    this.Health -= this.Health / 2;
                    CheckIfEffectShouldBeTriggered();
                    if (this.Health <= 0)
                    {
                        this.Health = 1;
                    }

                    targetGroup.Health -= this.Damage * defaultDamageBooster;
                    CheckIfEffectShouldBeTriggeredTarget(targetGroup);
                    break;
            }
        }

        public void Update()
        {
            //this will reduce the health/etc evey step
            if (this.IsEffectTriggered)
            {
                switch (this.WarEffect)
                {
                    case WarEffects.Jihad:
                        this.Damage -= 5;
                        break;

                    case WarEffects.Kamikaze:
                        this.Health -= 10;
                        break;
                }
            }

            // if the health becomes less than or equal half the inital
            if (this.TriggerWarEffect && this.IsEffectTriggered == false)
            {
                ApplyWarEffect();
            }

        }

        public void CheckIfEffectShouldBeTriggered()
        {
            if (this.Health <= initialHealth / 2)
            {
                this.TriggerWarEffect = true;
            }
            else { this.TriggerWarEffect = false; }
        }

        public void CheckIfEffectShouldBeTriggeredTarget(IGroup targetGroup)
        {
            if (targetGroup.Health <= targetGroup.InitialHealth / 2)
            {
                targetGroup.TriggerWarEffect = true;
            }
            else
            {
                targetGroup.TriggerWarEffect = false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //Group Cenko: 50 HP, 15 Damage
            //Group {name}: {health} HP, {damage} Damage
            sb.AppendFormat("Group {0}: {1} HP, {2} Damage",
                this.Name,
                this.Health,
                this.Damage)
                .AppendLine();

            return sb.ToString();
        }
    }
}
