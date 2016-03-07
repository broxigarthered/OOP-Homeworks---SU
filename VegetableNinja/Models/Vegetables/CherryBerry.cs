namespace ConsoleApplication1.Models.Vegetables
{
    using Contracts;

    public class CherryBerry : Vegetable
    {
        private const int TurnsUntillRegrowth = 5;

        private const int StaminaToIncrease = 10;

        public CherryBerry(INinja ninja, int xPosition, int yPosition)
            : base(ninja, xPosition, yPosition)
        {
            this.CurrentVegetableCharacter = 'C';
        }

        public override void ActivateEffect()
        {
            this.Ninja.Stamina += StaminaToIncrease;
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
