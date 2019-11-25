using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;

namespace FightSim
{
    class Program


    {

        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu mm = new MainMenu();
                Arena a1 = new Arena();

                a1.Battle();
                Console.Clear();



                

            }
            
        }
    }
}
