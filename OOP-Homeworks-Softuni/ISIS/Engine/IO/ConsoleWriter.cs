using System;
using Test1.Interfaces;

namespace Test1.Engine.IO
{
   public class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
