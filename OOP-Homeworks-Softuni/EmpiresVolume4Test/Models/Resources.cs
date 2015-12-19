using System.Resources;
using EmpiresVolume3.Interfaces;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Models
{
    public class Resources : IResource
    {
        public Resources(ResourceType resource, int quantity)
        {
            this.Resource = resource;
            this.Quantity = quantity;
        }

        public ResourceType Resource { get; }

        public int Quantity { get; }
    }
}
