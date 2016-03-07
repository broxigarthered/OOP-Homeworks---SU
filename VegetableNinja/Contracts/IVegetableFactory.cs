namespace ConsoleApplication1.Contracts
{
    public interface IVegetableFactory
    {
        IVegetable CreateVegetable(char vegetableCharValue, INinja ninja, int xPosition, int yPosition);
    }
}
