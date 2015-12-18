using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Empires.Interfaces;
using Empires.MyLogic;

namespace Empires.Models
{
    public class Engine : IEngine
    {
        private readonly IData data = new Data();
        private IInput inputReader = new Input();
        private IOutPut outputWriter = new Print();

        private readonly  IInput input;
       // private readonly IDatabase database;

        //private readonly IUpdatable updatable;
        public Engine()
        {
            this.inputReader = new Input();
            this.outputWriter = new Print();
            this.data = new Data();
        }

        public void Run()
        {
            string line = this.inputReader.ReadLine();
            

            while (line != "armistice")
            {
                
                string[] inputComands = line.Split(' ');
                

                switch (inputComands[0])
                {
                    case "build":
                        BuildCommand(inputComands);
                        break;

                    case "skip":
                        break;

                    case "empire-status":
                        PrintTreasury();
                        PrintBuildings();
                        PrintUnits();
                        break;
                }
                Update();
                line = this.inputReader.ReadLine();
            }
      }

        private void Update()
        {
            foreach (Building building in this.data.BuildingsData)
            {
                building.Update();

                if (building.CanProduceResource())
                {
                    this.data.AddResource(building.TypeOfResources, building.QuantityOfResources);
                }

                if (building.CanProduceUnit())
                {
                    this.data.AddUnit(building.UnitType);
                }
            }
        }

        private void PrintUnits()
        {
            StringBuilder unitsOutput = new StringBuilder();

            unitsOutput.AppendFormat("Units:{0}", Environment.NewLine);

            if (this.data.UnitsData.Any())
            {
                foreach (var unit in this.data.UnitsData)
                {
                    unitsOutput.AppendFormat("--{0}: {1}{2}",
                        unit.Key,
                        unit.Value,
                        Environment.NewLine);
                }
            }
            else
            {
                unitsOutput.AppendFormat("N/A{0}", Environment.NewLine);
            }
            this.outputWriter.Output(unitsOutput.ToString().Trim());
        }

        private void PrintBuildings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Buildings:");

            foreach (var building in this.data.BuildingsData)
            {
                sb.Append(building.ToString());
            }

            this.outputWriter.Output(sb.ToString().Trim());
        }

        private void PrintTreasury()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Treasury:").AppendLine();

            foreach (var resource in this.data.ResourcesData)
            {
                output.AppendFormat("--{0}: {1}", resource.Key,
                    resource.Value)
                    .AppendLine();
            }

            this.outputWriter.Output(output.ToString().Trim());
        }

        private void BuildCommand(string[] inputComands)
        {
            var typeOfBuilding = inputComands[1];
            var building = new BuildingFactory().CreateBuilding(typeOfBuilding);

            this.data.AddBuilding(building);
        }
    }
}