using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Healer : AdvancedCharacter, IHeal
    {
        public Healer(string id, int x, int y, int healthPoints, Team team) : base(id, x, y, healthPoints, team)
        {
        }

        public int HealingPoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
