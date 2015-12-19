using System;
using System.CodeDom;
using System.Linq;
using System.Text;
using EmpiresVolume3.Engine;
using EmpiresVolume3.Engine.Factories;
using EmpiresVolume3.Engine.IO;

namespace EmpiresVolume3.Interfaces
{
    public class Engine : IEngine
    {
        IConsoleReader input = new ConsoleReader();
        private ICommandParser commandParser = new CommandParser();
        private readonly string EndCommand = "armistice";


        public void Run()
        {

            var line = input.ReadLine();
            //logic
            while (line != EndCommand)
            {
                commandParser.UpdateAllBuildings();
                

                commandParser.ExecuteCommand(line);


                line = input.ReadLine();
            }

        }

    }
}
