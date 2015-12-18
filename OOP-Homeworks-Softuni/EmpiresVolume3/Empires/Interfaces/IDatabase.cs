using System.Collections.Generic;
using Empires.Interfaces;

namespace Empires.Models
{
    public interface IDatabase
    {
        IDictionary<ResourceType, int> Resource { get; }
        IList<IBuilding> Buildings { get; }
    }
}