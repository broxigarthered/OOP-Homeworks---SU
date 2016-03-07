namespace ConsoleApplication1
{
    using ConsoleApplication1.Core.Factories;

    using Contracts;
    using Core;

    public class VegetableNinjaApplication
    {
        public static void Main(string[] args)
        {
            IInputReader reader = new ConsoleReader();
            IOutputWriter outputWriter = new ConsoleWriter();
            IVegetableFactory vegetableFactory = new VegetableFactory();
            INinjaFactory ninjaFactory = new NinjaFactory();


            var engine = new Engine(
                reader,
                outputWriter,
                vegetableFactory,
                ninjaFactory);

            engine.Run();
        }
    }
}
