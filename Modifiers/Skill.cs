using System;
using System.Collections.Generic;

namespace cse210_DnDRoller
{
   public class Skill
    {  
        public string traitName ="";
        private int modifier = 0;
        private Dice mainDice = new Dice();
        
        

        //Gets the mainDiceSize
        public virtual void ObtainDiceSize(){
            mainDice.getSize(20);
        }

        //Sets the values of the Skill class.
        public virtual void setValues(string traitName, int modifier){
            this.traitName = traitName;
            this.modifier = modifier;
        }

    }
}