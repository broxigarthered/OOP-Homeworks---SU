namespace ConsoleApplication1.Contracts
{
    public interface IVegetable : IPositionable
    {
        bool DidRegrowth { get; set; }

        bool IsActive { get; set; }

        int TurnsCounter { get; set; }
        
        char CurrentVegetableCharacter { get; set; }

        void ActivateEffect();

        bool UpdateSpawn();

        void UpdateTurns();
    }
}
