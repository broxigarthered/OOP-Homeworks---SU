namespace ConsoleApplication1.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class Engine : IEngine
    {
        private IInputReader reader;

        private IOutputWriter outputWriter;

        private IVegetableFactory vegetableFactory;

        private INinjaFactory ninjaFactory;

        private INinja ninjaOne;

        private INinja ninjaTwo;

        private INinja currentNinja;

        private int firstNinjaStartingX;

        private int secondNinjaStartingX;

        private int firstNinjaStartingY;

        private int secondNinjaStartingY;

        private char[,] matrix;

        private int currentX;

        private int currentY;

        private int rows;

        private int cols;

        private bool isNinjaTwoTurn = false;

        private readonly ICollection<INinja> ninjas = new List<INinja>();

        private readonly ICollection<IVegetable> vegetables = new List<IVegetable>();

        private ICollection<IVegetable> collectedVegetables = new List<IVegetable>();

        public Engine(
            IInputReader reader,
            IOutputWriter outputWriter,
            IVegetableFactory vegetableFactory,
            INinjaFactory ninjaFactory)
        {
            this.InputReader = reader;
            this.OutputWriter = outputWriter;
            this.VegetableFactory = vegetableFactory;
            this.NinjaFactory = ninjaFactory;
        }

        #region properties

        public IVegetableFactory VegetableFactory
        {
            get
            {
                return this.vegetableFactory;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "The engine's attack factory cannot be null.");
                }

                this.vegetableFactory = value;
            }
        }

        public INinjaFactory NinjaFactory
        {
            get
            {
                return this.ninjaFactory;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "The engine's attack factory cannot be null.");
                }

                this.ninjaFactory = value;
            }
        }

        protected IInputReader InputReader
        {
            get
            {
                return this.reader;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "The engine's input reader cannot be null.");
                }

                this.reader = value;
            }
        }

        protected IOutputWriter OutputWriter
        {
            get
            {
                return this.outputWriter;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "The engine's output writer cannot be null.");
                }

                this.outputWriter = value;
            }
        }

        private INinja NinjaOne
        {
            get
            {
                return this.ninjaOne;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Engine's Ninja One cannot be null.");
                }

                this.ninjaOne = value;
            }
        }

        private INinja NinjaTwo
        {
            get
            {
                return this.ninjaTwo;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Engine's Ninja One cannot be null.");
                }

                this.ninjaTwo = value;
            }
        }

        #endregion

        #region methods
        public void Run()
        {
            this.ProcessInitialCommands();
           
                while (true)
                {
                    var commandArgs = this.reader.ReadLine();

                    this.ProcessCommand(commandArgs);
                }
        }

        protected virtual void ProcessInitialCommands()
        {
            var ninja1 = this.reader.ReadLine();
            var ninja2 = this.reader.ReadLine();

            string nm = this.reader.ReadLine();
            this.rows = int.Parse(nm.Split()[0]);
            this.cols = int.Parse(nm.Split()[1]);

            this.matrix = new char[this.rows, this.cols];

            for (int row = 0; row < this.rows; row++)
            {
                var rowToRead = this.reader.ReadLine();

                for (int col = 0; col < this.cols; col++)
                {
                    this.matrix[row, col] = rowToRead[col];
                    if (this.matrix[row, col] == ninja1[0])
                    {
                        this.firstNinjaStartingX = row;
                        this.firstNinjaStartingY = col;
                    }
                    else if (this.matrix[row, col] == ninja2[0])
                    {
                        this.secondNinjaStartingX = row;
                        this.secondNinjaStartingY = col;
                    }
                }
            }

            this.NinjaOne = this.NinjaFactory.CreateNinja(
                ninja1,
                this.firstNinjaStartingX,
                this.firstNinjaStartingY);
            this.NinjaTwo = this.NinjaFactory.CreateNinja(
                ninja2,
                this.secondNinjaStartingX,
                this.secondNinjaStartingY);

            this.ninjas.Add(this.NinjaOne);
            this.ninjas.Add(this.NinjaTwo);
        }

        public virtual void ProcessCommand(string commandArgs)
        {
            for (int i = 0; i < commandArgs.Length; i++)
            {
                // check which of the two ninjas turns is
                if (!this.isNinjaTwoTurn)
                {
                    this.currentNinja = this.NinjaOne;
                }
                else
                {
                    this.currentNinja = this.NinjaTwo;
                }

                char currentMove = commandArgs[i];

                switch (currentMove)
                {
                    case 'R':
                        this.currentY = this.currentNinja.Y + 1;
                        this.currentX = this.currentNinja.X;
                        break;
                    case 'L':
                        this.currentY = this.currentNinja.Y - 1;
                        this.currentX = this.currentNinja.X;
                        break;
                    case 'D':
                        this.currentX = this.currentNinja.X + 1;
                        this.currentY = this.currentNinja.Y;
                        break;
                    case 'U':
                        this.currentX = this.currentNinja.X - 1;
                        this.currentY = this.currentNinja.Y;
                        break;
                    default:
                        throw new ArgumentException("Unknown direction type.");
                }

                // reduces the stamina every turn
                this.currentNinja.Stamina--;

                // check if the current move gets out of the boundries of the array
                if (this.currentX > this.rows - 1)
                {
                    this.currentX -= 1;
                }
                else if (this.currentY > this.cols - 1)
                {
                    this.currentY -= 1;
                }
                else if (this.currentX < 0)
                {
                    this.currentX = 0;
                }
                else if (this.currentY < 0)
                {
                    this.currentY = 0;
                }

                // check if the current char value is a vegetable
                if (this.matrix[this.currentX, this.currentY] != '-' &&
                    this.matrix[this.currentX,this.currentY] != this.NinjaOne.Name[0] &&
                    this.matrix[this.currentX, this.currentY] != this.NinjaTwo.Name[0])
                {
                    var currentVegetableCharValue = this.matrix[this.currentX, this.currentY];
                    var vegetable = this.VegetableFactory.CreateVegetable(currentVegetableCharValue, this.currentNinja, this.currentX, this.currentY);
                    this.collectedVegetables.Add(vegetable);
                    this.vegetables.Add(vegetable);

                    // set the current vegetable position to blank after moved through
                    this.matrix[this.currentX, this.currentY] = '-';
                }


                // set the current ninja position, to the current moved position
                this.currentNinja.X = this.currentX;
                this.currentNinja.Y = this.currentY;


                // checks if the current ninja hits another ninja
                // if it hits, environment.Exit + ninja.toString()
           
                if (this.NinjaOne.X == this.NinjaTwo.X && this.NinjaOne.Y == this.NinjaTwo.Y)
                {
                    var output = this.WinnerChecker(this.NinjaOne, this.NinjaTwo, this.currentNinja);
                    this.outputWriter.WriteLine(output);
                    Environment.Exit(0);
                }

                // Updates the spawn of every vegetable and shit
                this.Update(this.NinjaOne, this.NinjaTwo);

                if (this.currentNinja.Stamina == 0)
                {
                    if (this.currentNinja == this.NinjaOne)
                    {
                        this.isNinjaTwoTurn = true;
                    }
                    else
                    {
                        this.isNinjaTwoTurn = false;
                    }

                    // after every switch of ninjas, the current ninja eats its vegetables and we reset the currently eated vegetables
                    this.EatVegetables(this.collectedVegetables);
                    this.collectedVegetables = new List<IVegetable>();
                }
            }
        }

        private string WinnerChecker(INinja ninjaOne, INinja ninjaTwo, INinja currentNinja)
        {
            // if the current ninja is ninja one, it checks if both ninjas have the same power and if they have the first one wins if they don't it checks if ninja one has the more power if it does he wins, if it doesn't the other ninja wins
            // same goes for the second ninja
            if (currentNinja == ninjaOne)
            {
                if (ninjaOne.Power == ninjaTwo.Power)
                {
                    return ninjaOne.ToString();
                }
                else if (ninjaOne.Power > ninjaTwo.Power)
                {
                    return ninjaOne.ToString();
                }
                else
                {
                    return ninjaTwo.ToString();
                }
            }
            else if (currentNinja == ninjaTwo)
            {
                if (ninjaTwo.Power == ninjaOne.Power)
                {
                    return ninjaTwo.ToString();
                }
                else if (ninjaTwo.Power > ninjaOne.Power)
                {
                    return ninjaTwo.ToString();
                }
                else
                {
                    return ninjaOne.ToString();
                }
            }

            return null;
        }

        private void EatVegetables(ICollection<IVegetable> collectedVegetables)
        {
            foreach (var collectedVegetable in collectedVegetables)
            {
                collectedVegetable.ActivateEffect();
            }
        }

        public virtual void Update(INinja ninjaOne, INinja ninjaTwo)
        {
            foreach (var vegetable in this.vegetables)
            {
                // check if the vegetable should respawn (if reached the respawnturns)
                if (!(ninjaOne.X == vegetable.X && ninjaOne.Y == vegetable.Y)
                    && !(ninjaTwo.X == vegetable.X && ninjaTwo.Y == vegetable.Y))
                {
                    // calls the inner logic for the vegetable and updates the turns
                    vegetable.UpdateTurns();
                }

                var shouldRegrowth = vegetable.UpdateSpawn();
                if (shouldRegrowth)
                {
                    this.matrix[vegetable.X, vegetable.Y] = vegetable.CurrentVegetableCharacter;
                }
            }
        }

        #endregion
    }
}
