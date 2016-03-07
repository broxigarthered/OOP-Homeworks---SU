namespace ConsoleApplication1.Models
{
    using System;

    using Contracts;

    public class Ninja : INinja
    {
        private const int StartingPower = 1;

        private const int StartingStamina = 1;

        private string name;

        private int stamina;

        private int power;

        private int xPosition;

        private int yPosition;

        public Ninja(
            string name,
            int xPosition,
            int yPosition)
        {
            this.Name = name;
            this.Power = StartingPower;
            this.Stamina = StartingStamina;
            this.X = xPosition;
            this.Y = yPosition;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Ninja's name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }

            set
            {
                if (value < 0)
                {
                    this.power = 0;
                }
                else
                {
                    this.power = value;
                }

            }
        }

        public int Stamina
        {
            get
            {
                return this.stamina;
            }

            set
            {
                if (value < 0)
                {
                    this.stamina = 0;
                }
                else
                {
                    this.stamina = value;
                }
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
                    throw new ArgumentException("Ninja's x position cannot be less than zero.");
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
                    throw new ArgumentException("Ninja's y position cannot be less than zero.");
                }

                this.yPosition = value;
            }
        }

        public void Update()
        {

        }

        public override string ToString()
        {
            return string.Format("Winner: {0}\r\nPower: {1}\r\nStamina: {2}", this.Name, this.Power, this.Stamina);
        }
    }
}
