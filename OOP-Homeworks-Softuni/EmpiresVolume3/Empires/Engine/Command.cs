using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Engine
{
    public abstract class Command : IExecutable
    {
        protected IUpdatable updatable;

        protected Command(IUpdatable updatable)
        {
            this.updatable = updatable;
        }

        public virtual void Execute()
        {
            this.updatable.Update();
        }
    }
}
