using System;
using System.Collections.Generic;

namespace cse210_DnDRoller
{
    public class SkillDice : Dice
    {   //Size, rolled value, and modifier
        public override void Roll(int value){
            size = 20;
        }
        
    }
}