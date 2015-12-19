namespace EmpiresVolume3.Models.Units
{
    public class Swordsman : Unit
    {
        private const int DefaultSwordsmanHealth = 40;
        private const int DefaultSwordsmanDamage = 13;
        private const string SwordsmanAsString = "Swordsman";

        public Swordsman()
            : base(DefaultSwordsmanHealth,
                  DefaultSwordsmanDamage,
                  SwordsmanAsString)
        {
        }
    }
}
