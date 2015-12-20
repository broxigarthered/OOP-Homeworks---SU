

using Test1.Interfaces;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine.Engine();

            engine.Run();
        }
    }
}
