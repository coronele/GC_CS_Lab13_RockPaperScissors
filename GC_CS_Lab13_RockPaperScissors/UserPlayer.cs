﻿using System;
using System.Collections.Generic;
using System.Text;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class UserPlayer : Player
    {
        public string GetName()
        {
            Name = GetUserInput("Please enter your name:");
            return Name;
        }
        public override Roshambo GenerateRoshambo()
        {
            char userSelection = Validator.rpsEvaluate(GetUserInput("Choose [R]ock, [P]aper, or [S]cissors: ").Trim().ToLower());
            
            switch (userSelection)
            {
                case 'r':
                    return Roshambo.Rock;
                case 'p':
                    return Roshambo.Paper;
                case 's':
                    return Roshambo.Scissors;
                default:
                    return GenerateRoshambo();
            }
        }

        

    }


}
