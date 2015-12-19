
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Interfaces
{
    public interface IResource
    {
        ResourceType Resource { get; }

        int Quantity { get; }
    }
}
