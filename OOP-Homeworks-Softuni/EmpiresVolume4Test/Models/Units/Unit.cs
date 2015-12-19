using System;
using System.Runtime.InteropServices;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Models.Units
{
    public abstract class Unit : IUnit
    {
        private int health;

        protected Unit(int health, int attack, string name)
        {
            this.Health = health;
            this.Attack = attack;
            this.Name = name;
        }


        public int Health {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("health","Unit's health cannot be less than zero.");
                }

                this.health = value;
            }
    }
        public int Attack { get; }
        public string Name { get; private set; }
    }
}
