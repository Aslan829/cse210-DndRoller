﻿using System;
using System.Text.Json;

namespace cse210_DnDRoller
{
    public class Program
    {
        //Create player class and set up the character sheet.
        
        static public void Main(String[] args)
        {

            Character player = new Character();
            GameRunner roller = new GameRunner();

            bool goAgain = true;

            while(goAgain){
                goAgain = roller.RunGame(goAgain, player);
            }

            


             //Create player class and set up the character sheet.
           /* sheetReader player = new sheetReader();
            player.getSheetLink();

            //Sets character sheet
            string jsonString = File.ReadAllText(player.characterLink);
            Console.WriteLine(jsonString);
            Character test = JsonSerializer.Deserialize<Character>(jsonString)!;
            Console.WriteLine("NAme is: " + test.name);*/
           
        }
        

    }
}
