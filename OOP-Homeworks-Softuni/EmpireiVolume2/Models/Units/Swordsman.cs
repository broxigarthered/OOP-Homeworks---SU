
namespace EmpireiVolume2.Models.Units
{
    public class Swordsman : Unit
    {
        private const int DefaultSwordsmanHealth = 40;
        private const int DefaultSwordsmanDamage = 13;

        public Swordsman() 
            : base(DefaultSwordsmanDamage, DefaultSwordsmanHealth)
        {
        }
    }
}
