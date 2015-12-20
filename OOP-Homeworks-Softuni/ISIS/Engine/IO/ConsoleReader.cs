using System;
using Test1.Interfaces;

namespace Test1.Engine.IO
{
    public class ConsoleReader : IConsoleReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
