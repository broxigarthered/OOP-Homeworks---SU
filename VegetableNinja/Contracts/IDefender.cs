namespace ConsoleApplication1.Contracts
{
    public interface IDefender
    {
        int Health { get; set; }

        bool IsAlive { get; }
    }
}
