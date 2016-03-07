namespace ConsoleApplication1.Core.Factories
{
    using Models;

    using Contracts;

    public class NinjaFactory : INinjaFactory
    {
        public INinja CreateNinja(string name, int xPosition, int intYPosition)
        {
            var ninja = new Ninja(name, xPosition, intYPosition);

            return ninja;
        }
    }
}
