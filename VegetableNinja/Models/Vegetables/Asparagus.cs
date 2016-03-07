namespace ConsoleApplication1.Models.Vegetables
{
    using Contracts;

    public class Asparagus : Vegetable
    {
        private const int TurnsUntillRegrowth = 2;

        private const int PowerToIncrease = 5;

        private const int StaminaToDecrease = 5;

        public Asparagus(INinja ninja, int xPosition, int yPosition)
             : base(ninja, xPosition, yPosition)
        {
            this.CurrentVegetableCharacter = 'A';
        }

        public override void ActivateEffect()
        {
            this.Ninja.Power += PowerToIncrease;
            this.Ninja.Stamina -= StaminaToDecrease;
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
