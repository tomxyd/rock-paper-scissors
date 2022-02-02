using System;

namespace RockPaperScissors_Example
{
    public class RockPaperScissors
    {


        public void Init()
        {
            string[] choices = { "rock", "paper", "scissors" };
            int userChoice;
            string playerPick = "";


            Console.WriteLine("Pick");
            Console.WriteLine("\t1 - Rock");
            Console.WriteLine("\t2 - Paper");
            Console.WriteLine("\t3- Scissors");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    playerPick = "rock";
                    break;
                case 2:
                    playerPick = "paper";
                    break;
                case 3:
                    playerPick = "scissors";
                    break;
            }

            var ai = AIPicker(choices);
            GameLogic(playerPick, ai);
        }

        public string AIPicker(string[] choice)
        {
            var rnd = new Random();
            int index = rnd.Next(choice.Length);
            string AIPick = choice[index];
            return AIPick;
        }

        void GameLogic(string player, string AI)
        {
            //rock beats scissors
            //scissors beats paper
            //paper beats rock
            Console.WriteLine($"Player picks {player}");
            Console.WriteLine($"AI picks {AI}");

            if (player != AI)
            {
                if ((player == "rock") && (AI == "scissors"))
                {
                    Console.WriteLine("Player1 Wins");
                }
                else if ((player == "scissors") && (AI == "paper"))
                {
                    Console.WriteLine("Player1 Wins");
                }
                else if ((player == "paper") && (AI == "rock"))
                {
                    Console.WriteLine("Player1 Wins");
                }
                else if ((AI == "scissors") && (player == "paper"))
                {
                    Console.WriteLine("AI Wins");
                }
                else if ((AI == "paper") && (player == "rock"))
                {
                    Console.WriteLine("AI Wins");
                }
                else if ((AI == "rock") && (player == "scissors"))
                {
                    Console.WriteLine("AI Wins");
                }
            }
            else
            {
                Console.WriteLine("Draw");
            }

        }

    }
}