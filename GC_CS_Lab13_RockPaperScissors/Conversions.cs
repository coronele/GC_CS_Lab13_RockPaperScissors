using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Conversions
    {
        public static char RoToChar(Roshambo ro)
        {
            switch (ro)
            {
                case Roshambo.Rock:
                    return 'r';
                case Roshambo.Paper:
                    return 'p';
                case Roshambo.Scissors:
                    return 's';
                default:
                    return ' ';
            }
        }

        public static string RoCharToString(char RoshamboChar)
        {
            switch (RoshamboChar)
            {
                case 'r':
                    return "rock";
                case 'p':
                    return "paper";
                case 's':
                    return "scissors";
                default:
                    return "";
            }
        }
    }
}
