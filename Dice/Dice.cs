using System;
using System.Collections.Generic;

namespace cse210_DnDRoller
{
   public class Dice
    {   //Size, rolled value, and modifier
        public int size = 0;
        public int value = 0;


        public virtual void Roll(int size){
            this.size = size;
        }
    }
}
