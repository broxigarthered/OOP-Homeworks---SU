
using System;
using System.Linq;
using System.Text;
using EmpiresVolume3.Engine.Factories;
using EmpiresVolume3.Engine.IO;
using EmpiresVolume3.Interfaces;

namespace EmpiresVolume3.Engine
{
    public class CommandParser : ICommandParser
    {
        IData data = new Data();
        IConsoleWriter output = new ConsoleWriter();
        IBuildingFactory factory = new BuildingFactory();
        private StringBuilder totalOutput = new StringBuilder();


        public void UpdateAllBuildings()
        {
            foreach (var building in this.data.Buildings)
            {
                building.Update();

                if (building.CanProduceResources)
                {
                    this.data.Treasury[building.Resource.Resource] += building.ResourcesQuantity;
                }

                if (building.CanProduceUnits)
                {
                    this.data.AddUnit(building.Unit.Name);
                }
            }
        }

        public void ExecuteCommand(string line)
        {
            var commandParams = line.Split(' ');
            var firstCommand = commandParams[0];

            switch (firstCommand)
            {
                case "build":
                    var buildingName = commandParams[1];
                    CreateNewBuilding(buildingName);
                    break;

                case "skip":
                    break;

                case "empire-status":
                    totalOutput.Append(PrintTreasuries());
                    totalOutput.Append(PrintBuildings());
                    totalOutput.Append(PrintUnits());

                    output.WriteLine(totalOutput.ToString());
                    totalOutput = new StringBuilder();
                    break;
            }

        }


        private string PrintTreasuries()
        {
            StringBuilder treasuryInfo = new StringBuilder();
            treasuryInfo.AppendFormat("Treasury:{0}", Environment.NewLine);

            foreach (var treasury in this.data.Treasury)
            {
                treasuryInfo.AppendFormat("--{0}: {1}{2}",
                    treasury.Key.ToString(),
                    treasury.Value,
                    Environment.NewLine);
            }
            return treasuryInfo.ToString();
        }

        private string PrintBuildings()
        {
            StringBuilder buildingOutput = new StringBuilder();

            buildingOutput.AppendLine("Buildings:");

            foreach (var building in this.data.Buildings)
            {
                buildingOutput.Append(building.ToString());
            }

            return buildingOutput.ToString();
        }

        private string PrintUnits()
        {
            StringBuilder unitsOutput = new StringBuilder();

            unitsOutput.AppendFormat("Units:{0}", Environment.NewLine);

            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    unitsOutput.AppendFormat("--{0}: {1}{2}",
                        unit.Key,
                        unit.Value,
                        Environment.NewLine);
                }
            }
            else
            {
                unitsOutput.AppendLine("N/A");
            }

            return unitsOutput.ToString();
        }

        private void CreateNewBuilding(string buildingName)
        {
            var building = factory.CreateBuilding(buildingName);
            this.data.AddBuilding(building);
        }

       
    }
}
