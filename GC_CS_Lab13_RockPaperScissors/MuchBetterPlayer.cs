using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    class MuchBetterPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            var choiceRand = new Random();
            int selection = choiceRand.Next(1, 4);

            switch (selection)
            {
                case 1:
                    return Roshambo.Rock;
                case 2:
                    return Roshambo.Paper;
                case 3:
                    return Roshambo.Scissors;
                default:
                    return Roshambo.Rock;
            }
        }

        public MuchBetterPlayer()
        {
            // Default constructor
            Name = "Gallant";
            Wins = 0;
        }
    }
}
