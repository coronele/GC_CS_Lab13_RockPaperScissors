using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Validator
    {
        public static char rpsEvaluate(string choice)
        {
            char userChoice = ' ';
            
            if (!(char.TryParse(choice, out userChoice)))
            {
                return rpsEvaluate(choice);
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
                return rpsEvaluate(choice);
            }

        }
    }
}
