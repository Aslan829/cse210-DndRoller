using System;
using System.Collections.Generic;

namespace cse210_DnDRoller
{
    public class sheetReader
    {   //Size, rolled value, and modifier
        // public override void Roll(int value){
        //     size = 20;
        // }
        public string characterLink = "";
        public void getSheetLink() {
            Console.WriteLine("What is the link to your character sheet? ");
            this.characterLink = Console.ReadLine();
            Console.WriteLine("\nLink is: " + this.characterLink);
        }
    }
}