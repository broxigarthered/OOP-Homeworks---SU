using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Char;

namespace TheSlum.GameEngine
{
    public class AdvancedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);

            switch (inputParams[0]) 
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;

                case "add":
                    AddItemToCharacter(inputParams);
                    break;
                   
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {

            string characterType = inputParams[1];
            string name = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            string teamType = inputParams[5];

            Team team = (Team) Enum.Parse(typeof(Team), teamType);

            Character currentChar = CharacterFactory.CreateCharacter(characterType,name,x,y,team);
            
            characterList.Add(currentChar);
        }

        protected void AddItemToCharacter(string[] inputParams)
        {
            string characterName = inputParams[1];
            string weaponType = inputParams[2];
            string id = inputParams[3];

                Item currentItem = GameEngine.ItemsFactory.CreateItem(weaponType, id);
                Character currentCharacter = characterList
             .First(x => x.Id == characterName);

            currentCharacter.AddToInventory(currentItem);
        }
    }
}
