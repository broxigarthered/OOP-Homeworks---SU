using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpiresVolume3.Interfaces;

namespace EmpiresVolume3.Engine.IO
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string output)
        {
            Console.Write(output);
        }
    }
}
