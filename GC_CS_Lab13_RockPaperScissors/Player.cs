using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab13_RockPaperScissors
{
    abstract class Player
    {
        private string name;

        virtual public string Name { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
