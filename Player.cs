using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek6_RPSGame
{
    public class Player
    {
        private string _name;
        private string _choice;

        public Player(string name)
        {
            _name = name;
        }

        public void MakeChoice()
        {
            Console.Write($"{_name}, enter ROCK, PAPER, or SCISSORS: ");
            _choice = Console.ReadLine().ToUpper();
        }
    }
}