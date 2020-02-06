using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    abstract class Player
    {
        private string name;
        private int wins;

        virtual public string Name { get; set; }
        virtual public int Wins { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
