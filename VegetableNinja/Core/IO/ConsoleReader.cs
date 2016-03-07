namespace ConsoleApplication1.Core
{
    using System;

    using Contracts;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();

            return line;
        }
    }
}
