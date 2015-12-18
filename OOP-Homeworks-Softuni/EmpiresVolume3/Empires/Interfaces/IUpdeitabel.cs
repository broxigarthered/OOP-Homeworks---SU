namespace Empires.Interfaces
{
    public interface IUpdatable
    {
        int Counter { get; }
        void Update();
    }
}