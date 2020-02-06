using System;
using System.Collections.Generic;
using System.Text;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Validator
    {
        public static char rpsEvaluate(string choice)
        {
            char userChoice = ' ';
            
            if (!(char.TryParse(choice, out userChoice)))
            {
                return rpsEvaluate(GetUserInput("Please enter 'r','p' or 's'."));
            }
            else
            {
                switch(userChoice)
                {
                    case 'r':
                    case 'p':
                    case 's':
                        return userChoice;
                }
                return rpsEvaluate(GetUserInput("Please enter 'r','p' or 's'."));
            }

        }
    }
}
