
using System;
using EmpiresVolume3.Interfaces;

namespace EmpiresVolume3.Engine.IO
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
