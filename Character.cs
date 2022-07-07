using System;
using System.Text.Json;

namespace cse210_DnDRoller
{
    public class Character
    {
        public string name = "...";
        public string characterLink = "";
        // private string characterData = "";
        //public List<Skill> SkillsList;
        //public List<Attack> AttackList;

        //Get the JSON character link.
        public void getSheetLink() {
            Console.WriteLine("What is the link to your character sheet? ");
            this.characterLink = Console.ReadLine();
            Console.WriteLine("\nLink is: " + this.characterLink);
        }

        //Read JSON character sheet.
        public void setCharacterSheet()
        {
            
            // Console.WriteLine(this.characterData);
        }

        //Add skills to skill list and attacks to attack lists.
        private void addToLists(){
            //...
        }

    }
}
