namespace ConsoleApplication1.Core
{
    using System;

    using Contracts;

    public class ConsoleWriter : IOutputWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
