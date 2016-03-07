namespace ConsoleApplication1.Models.Vegetables
{
    using Contracts;

    public class Mushroom : Vegetable
    {
        private const int TurnsUntillRegrowth = 5;

        private const int PowerToDecrease = 10;

        private const int StaminToDecrease = 10;

        public Mushroom(INinja ninja, int xPosition, int yPosition)
           : base(ninja, xPosition, yPosition)
        {
            this.CurrentVegetableCharacter = 'M';
        }

        public override void ActivateEffect()
        {
            this.Ninja.Stamina -= StaminToDecrease;
            this.Ninja.Power -= PowerToDecrease;
            this.IsActive = true;
        }

        public override bool UpdateSpawn()
        {
            if (this.TurnsCounter == TurnsUntillRegrowth)
            {
                this.DidRegrowth = true;
                this.TurnsCounter = 0;
            }
            else
            {
                this.DidRegrowth = false;
            }

            return this.DidRegrowth;
        }

        public override void UpdateTurns()
        {
            if (this.IsActive)
            {
                this.TurnsCounter++;
            }
        }

       
    }
}
