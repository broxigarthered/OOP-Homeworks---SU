using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Warrior : AdvancedCharacter, IAttack
    {
        public Warrior(string id, int x, int y, int healthPoints, Team team)
            : base(id, x, y, healthPoints, team)
        {
        }

        public int AttackPoints
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
