namespace ConsoleApplication1.Contracts
{
    public interface INinja : IPositionable
    {
        string Name { get; set; }

        int Power { get; set; }

        int Stamina { get; set; }
        
        void Update();

    }
}
