using System;
using System.Collections.Generic;

namespace cse210_DnDRoller
{
    public class GameRunner
    {   
        private string option = "BLANK";
        public bool RunGame(bool goAgain){
            Console.WriteLine("What kind of roll do you want?");
            Console.WriteLine("s for skill");
            Console.WriteLine("a for attack");
            Console.WriteLine("c for a custom roll");
            Console.WriteLine("q to quit");
            Console.WriteLine("Option: ");
            option = Console.ReadLine();

            switch(option)
            {
                case "s":
                    this.skillRoll();
                    break;
                case "a":
                    this.attackRoll();
                    break;
                case "c":
                    this.customRoll();
                    break;
                case "q":
                    goAgain = false;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

            return goAgain;



        }

        public void skillRoll(){
            //...
        }

        public void attackRoll(){
            //...
        }

        public void customRoll(){
            //...
        }

        

    }
}