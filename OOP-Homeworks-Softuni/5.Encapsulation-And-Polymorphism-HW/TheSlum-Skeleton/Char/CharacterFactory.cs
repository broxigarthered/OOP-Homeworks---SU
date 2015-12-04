using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.GameObjects.Characters;

namespace TheSlum.Char
{
   public static class CharacterFactory
    {
       public static Character CreateCharacter(string type,string id, int x, int y, Team team)
       {
           switch (type.ToLower())
           {
                case "mage":
                    return new Mage(id,x,y,team);

                case "warrior":
                    return new Mage(id,x,y,team);
                 
                case "healer":
                    return new Healer(id,x,y,team);

                default:
                    throw new ArgumentException("No such type of character there is.");

            }
           
       }
    }
}
