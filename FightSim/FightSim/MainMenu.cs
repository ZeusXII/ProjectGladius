using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class MainMenu
    {
        
        public int userInput;

        public MainMenu()
        {

            while (true)
            {
                Console.WriteLine("Welcome to project Gladius");
                Console.WriteLine("1. Start new game");
                Console.WriteLine("0. Exit program");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Welcome to the game");
                    break;
                }
                else if (option == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Only the 1 or 0 buttons are accepted! Press enter to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                

            }

        }

      



    }
}
