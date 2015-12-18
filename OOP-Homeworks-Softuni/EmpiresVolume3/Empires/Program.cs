using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Models.Engine();

            engine.Run();
        }
    }
}
