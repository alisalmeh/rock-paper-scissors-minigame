using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek6_RPSGame
{
    public class Player
    {
        public string Name { get; set; }
        public string Choice { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public string MakeValidChoice()
        {
            Console.Clear();
            Console.Write($"{Name}, enter ROCK, PAPER, or SCISSORS: ");

            while (true)
            {
                string choice = Console.ReadLine().ToUpper();

                if (choice == "ROCK" || choice == "PAPER" || choice == "SCISSORS")
                {
                    return Choice = choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter ROCK, PAPER, or SCISSORS.");
                }
            }
        }

        public void MakeChoiceRandom()
        {
            Random random = new Random();

            var choices = new string[] { "ROCK", "PAPER", "SCISSORS" };
            var randomIndex = random.Next(choices.Length);

            Choice = choices[randomIndex];
        }

        public static string GetUserName()
        {
            while (true)
            {
                Console.WriteLine("Please Enter Your Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("\"Name\" cannot be empty!");
                }
                else
                {
                    return name;
                }
            }
        }
    }
}