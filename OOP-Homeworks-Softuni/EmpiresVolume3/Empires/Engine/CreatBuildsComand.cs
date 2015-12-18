using System.Collections.Generic;
using Empires.Engine;
using Empires.Interfaces;

namespace Empires.Models
{
    public class CreatBuildsComand : Command
    {
        public CreatBuildsComand(string buildType, IList<IBuilding> buildings,IUpdatable updatable)
            :base(updatable)
           
        {
            this.Type = buildType;
            this.Buildings = buildings;
        }

        public IList<IBuilding> Buildings { get; set; }
        public string Type { get;
            
set; }
        
    }
}