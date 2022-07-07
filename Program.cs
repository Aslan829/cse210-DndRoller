using System;
using System.Text.Json;

namespace cse210_DnDRoller
{
    public class Program
    {
        //Create player class and set up the character sheet.
        
        static public void Main(String[] args)
        {
             //Create player class and set up the character sheet.
            Character player = new Character();
            player.getSheetLink();

            //Sets character sheet
            string jsonString = File.ReadAllText(player.characterLink);
            Console.WriteLine(jsonString);
            Character test = JsonSerializer.Deserialize<Character>(jsonString)!;
            Console.WriteLine("NAme is: " + test.name);
           
        }
        

    }
}
