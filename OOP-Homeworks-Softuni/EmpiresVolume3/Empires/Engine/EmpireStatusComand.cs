using System.Collections.Generic;
using Empires.Engine;
using Empires.Interfaces;

namespace Empires.Models
{
    public class EmpireStatusComand : Command
    {
        public EmpireStatusComand(IDatabase database, IOutPut output, IUpdatable updatable)
            : base(updatable)
        {
            Database = database;
            Output = output;
        }

        public IDatabase Database { get; set; }
        public IOutPut Output { get; set; }

    }
}