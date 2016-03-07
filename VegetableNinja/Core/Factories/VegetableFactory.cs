namespace ConsoleApplication1.Core.Factories
{
    using System;

    using Models.Vegetables;

    using Contracts;

    public class VegetableFactory : IVegetableFactory
    {
        public IVegetable CreateVegetable(char vegetableCharValue, INinja ninja, int xPosition, int yPosition)
        {
            if (ninja == null)
            {
                throw new ArgumentNullException("Ninja cannot be null when creating it.");
            }

            switch (vegetableCharValue)
            {
                case 'A':
                    return new Asparagus(ninja, xPosition, yPosition);
                case 'B':
                    return new Broccoli(ninja, xPosition, yPosition);
                case 'C':
                    return new CherryBerry(ninja, xPosition, yPosition);
                case 'M':
                    return new Mushroom(ninja, xPosition, yPosition);
                case 'R':
                    return new Royal(ninja, xPosition, yPosition);
                default:
                    throw new ArgumentException("Unknown vegetable type."); 
            }
        }
    }
}

//public IAttack CreateAttack(string attackType, IBlob blob)
//{
//    var type = Assembly.GetExecutingAssembly().GetTypes()
//        .FirstOrDefault(t => t.Name == attackType);

//    if (type == null)
//    {
//        throw new ArgumentException("Unknown attack type.");
//    }

//    var attack = (IAttack)Activator.CreateInstance(type, blob);

//    return attack;
//}