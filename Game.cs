using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek6_RPSGame
{
    public class Game
    {
        private Player _player;
        private Player _computer;
        private Random _random;
        private int _playerWins;
        private int _computerWins;
        private int _rounds;


        public Game(string playerName)
        {
            _player = new Player(playerName);
            _computer = new Player("computer");
            _random = new Random();
            _playerWins = 0;
            _computerWins = 0;
            _rounds = 0;
        }

        private bool GetPlayAgainInput()
        {
            while (true)
            {
                Console.WriteLine("Would you like to play again (Y/N)?");
                var play = Console.ReadLine().ToUpper();

                if (play == "Y")
                {
                    return true;
                }
                else if (play == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You entered invalid character!!\n\tTRY AGAIN:");
                }
            }
        }

        private string GetRoundResult(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return "It's a DRAW -__-";
            }
            else if (
                (playerChoice == "ROCK" && computerChoice == "SCISSORS") ||
                (playerChoice == "PAPER" && computerChoice == "ROCK") ||
                (playerChoice == "SCISSORS" && computerChoice == "PAPER")
                    )
            {
                return "You WIN *__*";
            }
            else
            {
                return "You LOSE :((";
            }
        }

        public void Play()
        {
            bool playAgain;

            do
            {
                _player.MakeValidChoice();
                _computer.MakeChoiceRandom();

                Console.WriteLine($"\nPlayer: {_player.Choice}\nComputer: {_computer.Choice}");

                string _result = GetRoundResult(_player.Choice, _computer.Choice);
                Console.WriteLine(_result);

                if (_result == "You WIN *__*")
                {
                    _playerWins++;
                }
                else if (_result == "You LOSE :((")
                {
                    _computerWins++;
                }

                _rounds++;

                Console.WriteLine($"Rounds: {_rounds}\nPlayer {_playerWins}-{_computerWins} Computer\n");

                playAgain = GetPlayAgainInput();

            } while (playAgain);

            Console.WriteLine("Thanks for playing *__*");
        }
    }
}