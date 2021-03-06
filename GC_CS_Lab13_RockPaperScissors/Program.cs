﻿using System;
using System.Collections.Generic;
using static GC_CS_Lab13_RockPaperScissors.MyMethods;

namespace GC_CS_Lab13_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTitle("Time to play Rock, Paper, Scissors!");
            
            // Create player child classes
            UserPlayer you = new UserPlayer();
            IThrowRock easyplayer = new IThrowRock();
            MuchBetterPlayer hardplayer = new MuchBetterPlayer();

            SetOutputColor();
            
            // Select the opponent
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
            
            // Game played here
            PlayGame.RPS(player[0], player[1]);
        }
    }
}
