using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    class IThrowRock : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

        public IThrowRock()
        {
            // Default constructor
            Name = "Goofus";
            Wins = 0;
        }
    }
}
