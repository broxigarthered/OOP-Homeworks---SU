using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Models
{
    public abstract class Unit : IUnit
    {
        protected Unit(int health, int attackDamage)
        {
            Health = health;
            AttackDamage = attackDamage;
        }
        public int Health { get; set; }
        public int AttackDamage { get; }
    }
}
