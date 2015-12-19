
using System.Resources;
using EmpiresVolume3.Types;

namespace EmpiresVolume3.Interfaces
{
    public interface IBuilding
    {
        IUnit Unit { get; }

        IResource Resource { get; }

        int ResourcesRequiredTurns { get; }

        int UnitRequiredTurns { get; }

        int ResourcesQuantity { get; }

        bool CanProduceResources { get; }

        bool CanProduceUnits { get; }

        void Update();
    }
}
