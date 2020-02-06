using System;
using System.Collections.Generic;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTitle("Time to play Rock, Paper, Scissors!");
            UserPlayer you = new UserPlayer();
            IThrowRock easyplayer = new IThrowRock();
            MuchBetterPlayer hardplayer = new MuchBetterPlayer();


            Console.WriteLine($"\n[1] Super easy\t[2] More difficult");
            int userDiff = UserChoice("Choose a difficulty level [1-2]", "That is not a valid choice", 2);

            List<Player> player = new List<Player>();
            player.Add(you);

            if (userDiff == 1)
            {
                player.Add(easyplayer);
            }
            else
            {
                player.Add(hardplayer);
            }
            PlayGame.RPS(player[0], player[1]);
        }

        static void TestAndDelete()
        {
            IThrowRock One = new IThrowRock();
            MuchBetterPlayer Two = new MuchBetterPlayer();
            UserPlayer Three = new UserPlayer();

            List<Player> playerList = new List<Player>
            {
                One, Two, Three
            };

            foreach (Player p in playerList)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(Conversions.RoCharToString(Conversions.RoToChar(p.GenerateRoshambo())));
            }
        }
    }
}
