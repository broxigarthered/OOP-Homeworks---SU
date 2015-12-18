using System;
using Empires.Engine;
using Empires.Interfaces;

namespace Empires.Models
{
    public class SkipComand : Command
    {
        private readonly IUpdatable updatable;

        public SkipComand(IUpdatable updatable)
            : base(updatable)
        {
        }

    }
}