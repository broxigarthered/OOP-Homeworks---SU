using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.GameObjects.Items;


namespace TheSlum.GameEngine
{
    public static class ItemsFactory
    {
        public static Item CreateItem(string weaponType, string id)
        {
            switch (weaponType.ToLower())
            {
                case "axe":
                    return new Axe(id);

                case "injection":
                    return new Injection(id);

                case "pill":
                    return new Pill(id);

                case "shield":
                    return new Shield(id);

                default:
                    throw new ArgumentException("Such item doesn't exist.");
            }
        }
    
}
}
