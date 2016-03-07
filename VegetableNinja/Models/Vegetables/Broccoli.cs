namespace ConsoleApplication1.Models.Vegetables
{
    using Contracts;

    public class Broccoli : Vegetable
    {
        private const int TurnsUntillRegrowth = 3;

        private const int PowerToIncrease = 10;

        public Broccoli(INinja ninja, int xPosition, int yPosition)
           : base(ninja, xPosition, yPosition)
        {
            this.CurrentVegetableCharacter = 'B';
        }

        public override void ActivateEffect()
        {
            this.Ninja.Power += PowerToIncrease;
            this.IsActive = true;
           // this.TurnsCounter++;
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
