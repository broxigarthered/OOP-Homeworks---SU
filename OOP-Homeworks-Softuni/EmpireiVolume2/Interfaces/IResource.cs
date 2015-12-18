
using EmpireiVolume2.Types;

namespace EmpireiVolume2.Interfaces
{
    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }

    }
}
