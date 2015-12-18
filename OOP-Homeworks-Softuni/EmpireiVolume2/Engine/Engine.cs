
using System.Linq;
using System.Text;
using System.Xml;
using EmpireiVolume2.Engine.Factories;
using EmpireiVolume2.Engine.IO;
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Models;
using EmpireiVolume2.Models.Buildings;
using EmpireiVolume2.Models.Units;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Engine
{
    class Engine : IEngine
    {
        //initializing teh shiet
        private const string EndCommand = "armistice";
        private readonly IBuildingFactory buildingFactory = new BuildingFactory();
        private readonly Data Data = new Data();
        private ConsoleWriter writer = new ConsoleWriter();
        

        public void Run()
        {
            
            var line = new ConsoleReader();
            var input = line.ReadLine();

            while (input != EndCommand)
            {
                ExecuteCommand(input);
                this.UpdateBuildings(); // call the update method on buildings in every iteration

                input = line.ReadLine();
            }

        }

        public void UpdateBuildings()
        {
            // Logic for update
            foreach (var building in this.Data.Buildings)
            {
                // For every single building in the data class, (the collector of buildings) update the building. (check the update and tostring methods in Building)
                building.Update();

                // For the current building check if it's able to produce resources/units (check the boolean operators in Building). If they return true, simply put the fixed quantity in the current type for resources in the data class and respectively the same for the units.
                if (building.CanProduceResource)
                {
                    var resource = building.Resource;
                    this.Data.Resources[resource.ResourceType.ToString()] += resource.Quantity;
                }

                if (building.CanProduceUnit)
                {
                    // get the type of unit, and call the AddUnit method (check in Data, what it does)
                    var unit = building.Unit;
                    this.Data.AddUnit(unit);
                }
            }

        }


        private void ExecuteCommand(string input)
        {
            var commandParams = input.Split(' ');

            switch (commandParams[0])
            {
                case "build":
                    BuildCommmand(commandParams[1]);
                    break;
                case "skip":
                    break;
                case "empire-status":
                    EmpireStatusCommand();
                    break;

            }
        }

        private void EmpireStatusCommand()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append(GetTreasuryValue());
            sb.Append(GetBuildingsValue());
            sb.Append(GetUnitsValue());

            //call the writer class, instead of directly printing it to the console
            this.writer.WriteLine(sb.ToString());
        }

        //Method for printing the units
        private string GetUnitsValue()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Units:")
                .AppendLine();

            if (this.Data.Units.Any())
            {
                foreach (var unit in this.Data.Units)
                {
                    sb.AppendFormat("--{0}: {1}",
                        unit.Key, unit.Value)
                        .AppendLine();
                }
            }

            else { 
                sb.Append("N/A");
            }
           
            return sb.ToString().Trim();
        }

        //method for printing the buildings
        private string GetBuildingsValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Buildings:");

            if (this.Data.Buildings.Any())
            {
                foreach (var building in this.Data.Buildings)
                {
                    sb.Append(building.ToString());
                }
                sb.AppendLine();
            }
            else
            {
                sb.Append("N/A");
            }
            return sb.ToString();
        }

        // Method for printing the treasury
        private string GetTreasuryValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Treasury:")
                .AppendLine();

            foreach (var resource in this.Data.Resources)
            {
                sb.AppendFormat("--{0}: {1}",
                    resource.Key, resource.Value)
                    .AppendLine();

            }
            return sb.ToString();
        }

        private void BuildCommmand(string typeOfBuilding)
        {
            // Use the building factory to generate a type of building and then put it in the Data class
            IBuilding building = this.buildingFactory.CreateNewBuilding(typeOfBuilding);

            this.Data.Buildings.Add(building);
        }
    }
}
