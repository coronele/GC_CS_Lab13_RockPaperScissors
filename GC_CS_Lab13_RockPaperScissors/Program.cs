using System;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            IThrowRock Tom = new IThrowRock();
            Tom.GenerateRoshambo();
            Tom.Name = "Tom";
        }
    }
}
