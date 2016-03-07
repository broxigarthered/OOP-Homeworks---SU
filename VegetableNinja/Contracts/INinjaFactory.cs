namespace ConsoleApplication1.Contracts
{
    public interface INinjaFactory
    {
        INinja CreateNinja(string name, int xPosition, int yPosition);
    }
}
