using System;
using System.Security.Cryptography;
using System.Text;
using Test1.Engine.Factories;
using Test1.Engine.IO;
using Test1.Interfaces;

namespace Test1.Engine
{
    public class Engine : IEngine
    {
        //initialize
        private static IWarEffectFactory warEffectFactory = new WarEffectFactory();
        private static IAttackFactory attackFactory = new AttackFactory();
        private static IData data = new Data();
        private static StringBuilder totalOutput = new StringBuilder();
        private static IConsoleWriter output = new ConsoleWriter();

        private const string EndCommand = "world.apocalypse()";
        private ICommandParser commandParser = new CommandParser(warEffectFactory,
            attackFactory,
            data,
            totalOutput,
            output
            );
        

        public void Run()
        {
            var line = new ConsoleReader();
            var input = line.ReadLine();

            while (input != EndCommand)
            {
                commandParser.ExecuteCommand(input);

                //commandParser.UpdateGroups();

                input = line.ReadLine();
            }
        }
    }
}
