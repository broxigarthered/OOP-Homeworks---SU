

using EmpireiVolume2.Engine;

namespace EmpireiVolume2.Interfaces
{
    public interface IBuilding
    {
        IUnit Unit { get; }

        IResource Resource { get; }

        int TotalTurnsPlayed { get; }

        

        bool CanProduceResource { get; }

        bool CanProduceUnit { get; }

       
        void Update();
    }
}
