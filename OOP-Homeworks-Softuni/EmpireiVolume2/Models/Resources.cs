
using EmpireiVolume2.Interfaces;
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Models
{
    public class Resources : IResource
    {
        public Resources(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; }

        public int Quantity { get; }
    }
}
