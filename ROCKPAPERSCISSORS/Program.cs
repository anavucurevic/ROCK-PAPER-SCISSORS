using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROCKPAPERSCISSORS
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputPlayer, inputComputer;
            int random;

            

            bool playAgain = true;

            while (playAgain) { 

            int userPoints=0;
            int computerPoints=0;

            while (userPoints<3 && computerPoints<3)
            {

                    
                    Console.WriteLine("\tPlease select ROCK, PAPER OR SCISSORS:   \t");
                    inputPlayer = Console.ReadLine();

                    Random ran = new Random();
                    random = ran.Next(1, 4);


                    switch (random)
            {

                case 1:
                    inputComputer = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                            Console.WriteLine("You chose {0}", Check(inputPlayer));

                    if (Check(inputPlayer) == "ROCK") { Console.WriteLine("TIE"); }
                    else if (Check(inputPlayer) == "PAPER") { Console.WriteLine("YOU WIN THIS ROUND"); userPoints++; }
                    else if (Check(inputPlayer) == "SCISSORS") { Console.WriteLine("YOU LOST THIS ROUND"); computerPoints++; }
  
                    break;

                case 2:
                    inputComputer = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                            Console.WriteLine("You chose {0}", Check(inputPlayer));

                            if (Check(inputPlayer) == "PAPER") { Console.WriteLine("TIE"); }
                    else if (Check(inputPlayer) == "ROCK") { Console.WriteLine("YOU WIN THIS ROUND"); computerPoints++; }
                    else if (Check(inputPlayer) == "SCISSORS") { Console.WriteLine("YOU LOST THIS ROUND"); userPoints++; }
                    break;
                case 3:
                    inputComputer = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                            Console.WriteLine("You chose {0}", Check(inputPlayer));
                            if (Check(inputPlayer) == "SCISSORS") { Console.WriteLine("TIE"); }
                    else if (Check(inputPlayer) == "ROCK") { Console.WriteLine("YOU WIN THIS ROUND"); userPoints++; }
                    else if (Check(inputPlayer) == "PAPER") { Console.WriteLine("YOU LOST THIS ROUND"); computerPoints++; }

                    break;


                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
            }
            

            Console.WriteLine("\n\nSCORE:\tYOU:\t{0}\tCOMPUTER:\t{1}", userPoints,computerPoints);

            if (computerPoints == 3)
            {
                Console.WriteLine("\n ***** YOU LOST ****\n");
            }else if (userPoints == 3) { Console.WriteLine("\n ***** YOU WON! ****\n"); }
            else { }


               
               
                
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                    }
                else
                {
                        Console.WriteLine("Invalid answer ");
                    playAgain = false;
                }
                

            }



            Console.WriteLine("THANK YOU FOR PLAYING!");


        }


        public static string Check(string userCh)
        {

            if (userCh.ToUpper() == "rock".ToUpper()) { return "ROCK"; }
            if (userCh.ToUpper() == "paper".ToUpper()) { return "PAPER"; }
            if (userCh.ToUpper() == "scissors".ToUpper()) { return "SCISSORS"; }
            return "not written properly please try again";

        }

   



    }



}
