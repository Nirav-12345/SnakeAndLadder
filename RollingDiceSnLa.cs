﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingnumberRolls
{
    internal class RollingDiceSnLa
    {

        public static void RollsTheDie()

        {
           

            Random random = new Random();
        int DiceRoll = random.Next(1, 7);

        Console.WriteLine("The Number is :" + DiceRoll);
            
        }
}
    }

