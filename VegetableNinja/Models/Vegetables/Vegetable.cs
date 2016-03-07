namespace ConsoleApplication1.Models.Vegetables
{
    using System;

    using Contracts;

    public abstract class Vegetable : IVegetable
    {
        private INinja ninja;

        private int xPosition;

        private int yPosition;

        protected Vegetable(INinja ninja, int xPosition, int yPosition)
        {
            this.Ninja = ninja;
            this.X = xPosition;
            this.Y = yPosition;
        }

        public INinja Ninja
        {
            get
            {
                return this.ninja;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "The vegetable's ninja cannot be null.");
                }

                this.ninja = value;
            }
        }

        public int X
        {
            get
            {
                return this.xPosition;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Vegetable's x position cannot be less than zero.");
                }

                this.xPosition = value;
            }
        }

        public int Y
        {
            get
            {
                return this.yPosition;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Vegetable's y position cannot be less than zero.");
                }

                this.yPosition = value;
            }
        }

        public virtual bool DidRegrowth { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual int TurnsCounter { get; set; } 

        public virtual char CurrentVegetableCharacter { get; set; }

        public virtual void ActivateEffect()
        {
        }

        public virtual bool UpdateSpawn()
        {
            return false;
        }

        public virtual void UpdateTurns()
        {
        }
    }
}
