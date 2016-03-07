namespace ConsoleApplication1.Contracts
{
    public interface IAttacker
    {
        int Damage { get; set; }

        string AttackType { get; }

        // IAttack CreateAttack
    }
}
