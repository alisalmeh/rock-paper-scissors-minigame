﻿using System;

namespace AliSalmeh_ProjectWeek6_RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            Game game = new Game(playerName);
            game.Play();
        }
    }
}
