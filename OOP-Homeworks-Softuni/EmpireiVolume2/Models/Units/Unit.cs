

using EmpireiVolume2.Interfaces;

namespace EmpireiVolume2.Models
{
    public abstract class Unit : IUnit
    {
        protected Unit(int attack, int healt)
        {
            this.Attack = attack;
            this.Healt = healt;
        }


        public int Attack { get; }

        public int Healt { get; }
    }
}
