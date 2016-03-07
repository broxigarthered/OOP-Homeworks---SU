namespace ConsoleApplication1.Contracts
{
    public interface IEngine : IRunnable, IUpdateable
    {
        void ProcessCommand(string commandArgs);
        
    }
}
