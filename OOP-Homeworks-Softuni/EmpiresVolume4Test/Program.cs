

using EmpiresVolume3.Interfaces;

namespace EmpiresVolume3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Interfaces.Engine();
            engine.Run();
        }
    }
}
