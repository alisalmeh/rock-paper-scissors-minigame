using System;

namespace AliSalmeh_ProjectWeek6.RPSGame_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string playerChoice, answer;
            int playerWins = 0, computerWins = 0, rounds = 0;
            Random random = new Random();

            do
            {
                var choices = new string[] { "ROCK", "PAPER", "SCISSORS" };
                var num = random.Next(0, 3);

                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                playerChoice = Console.ReadLine().ToUpper();
                playerChoice = BadCommand(playerChoice);

                Console.WriteLine($"\nPlayer: {playerChoice}\nComputer: {choices[num]}");

                switch (playerChoice)
                {
                    case "ROCK" when choices[num] == "PAPER":
                    case "PAPER" when choices[num] == "SCISSORS":
                    case "SCISSORS" when choices[num] == "ROCK":
                        Console.WriteLine("You LOSE :((");
                        computerWins++;
                        break;
                    case "ROCK" when choices[num] == "SCISSORS":
                    case "PAPER" when choices[num] == "ROCK":
                    case "SCISSORS" when choices[num] == "PAPER":
                        Console.WriteLine("You WIN *__*");
                        playerWins++;
                        break;
                    case "ROCK" when choices[num] == "ROCK":
                    case "PAPER" when choices[num] == "PAPER":
                    case "SCISSORS" when choices[num] == "SCISSORS":
                        Console.WriteLine("It's a DRAW -__- ");
                        break;
                    default:
                        break;
                }
                rounds++;

                Console.WriteLine($"Rounds: {rounds}\nPlayer {playerWins}-{computerWins} Computer ");
                Console.WriteLine();

                Console.WriteLine("Would you like to play again (Y/N)?");
                answer = Console.ReadLine().ToUpper();
                answer = Again(answer);

                playAgain = answer == "Y" ? true : false;
            } while (playAgain);

            Console.WriteLine("Thanks for playing *__*");
        }

        static string BadCommand(string player)
        {
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("You entered invalid item!!\n\tTRY AGAIN:");
                player = Console.ReadLine().ToUpper();
            }
            return player;
        }

        static string Again(string play)
        {
            while (play != "Y" && play != "N")
            {
                Console.WriteLine("You entered invalid character!!\n\tTRY AGAIN:");
                play = Console.ReadLine().ToUpper();
            }
            return play;
        }
    }
}