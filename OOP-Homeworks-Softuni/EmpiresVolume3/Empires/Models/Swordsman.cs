namespace Empires.Models
{
    public class Swordsman : Unit
    {
        //- has default values of 40 health and 13 damage
        private const int SwordsHealth = 40;
        private const int SwordsDamage = 13;
        public Swordsman() 
            : base(SwordsHealth, SwordsDamage)
        {
        }
    }
}