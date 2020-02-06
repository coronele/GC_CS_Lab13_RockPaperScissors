using System;
using System.Collections.Generic;
using System.Text;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class PlayGame
    {
        public static void RPS(Player you, Player them)
        {
            string continuePlaying = "y";
            int ties = 0;

            do
            {
                char yourThrow = Conversions.RoToChar(you.GenerateRoshambo());
                char theirThrow = Conversions.RoToChar(them.GenerateRoshambo());
                SetOutputColor();
                if (yourThrow == 'r') // you throw rock
                {
                    Console.WriteLine($"{you.Name} threw {Conversions.RoCharToString(yourThrow)}");
                    if (theirThrow == 'r') // they throw rock
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("TIE!");
                        ties++;
                    }
                    else if (theirThrow == 'p') // they throw paper
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Paper covers rock.");
                        Console.WriteLine($"{them.Name} wins!");
                        them.Wins++;
                    }
                    else // they throw scissors
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Rock breaks scissors.");
                        Console.WriteLine($"{you.Name} wins!");
                        you.Wins++;
                    }
                }
                else if (yourThrow == 'p') // you throw paper
                {
                    Console.WriteLine($"{you.Name} threw {Conversions.RoCharToString(yourThrow)}");
                    if (theirThrow == 'r') // they throw rock
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Paper covers rock.");
                        Console.WriteLine($"{you.Name} wins!");
                        you.Wins++;
                    }
                    else if (theirThrow == 'p') // they throw paper
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine($"TIE!");
                        ties++;
                    }
                    else // they throw scissors
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Scissors cut paper.");
                        Console.WriteLine($"{them.Name} wins!");
                        them.Wins++;
                    }

                }
                else // you throw scissors
                {
                    Console.WriteLine($"{you.Name} threw {Conversions.RoCharToString(yourThrow)}");
                    if (theirThrow == 'r') // they throw rock
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Rock breaks scissors.");
                        Console.WriteLine($"{them.Name} wins!");
                        them.Wins++;
                    }
                    else if (theirThrow == 'p') // they throw paper
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine("Scissors cut paper.");
                        Console.WriteLine($"{you.Name} wins!");
                        you.Wins++;
                    }
                    else // they throw scissors
                    {
                        Console.WriteLine($"{them.Name} threw {Conversions.RoCharToString(theirThrow)}");
                        Console.WriteLine($"TIE!");
                        ties++;
                    }

                }
                Console.WriteLine("SCORE:");
                Console.WriteLine($"{you.Name}\t{you.Wins}");
                Console.WriteLine($"{them.Name}\t{them.Wins}");
                Console.WriteLine($"Ties\t{ties}\n\n");
                continuePlaying = YN_UserChoice("Would you like to play again? [y/n]", "Please enter 'y' or 'n'.");
            }
            while (continuePlaying == "y");
            SetOutputColor();
            Console.WriteLine("Thank you for playing!");
            Console.ResetColor();
        }
    }
}
