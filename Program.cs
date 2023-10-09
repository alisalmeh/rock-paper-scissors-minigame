using System;

namespace AliSalmeh_ProjectWeek6_RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            string playerName = Player.GetUserName();

            Game game = new Game(playerName);
            game.Play();
        }
    }
}