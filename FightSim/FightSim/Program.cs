using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program


    {




        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu mm = new MainMenu();



                Fighter A = new Fighter();
                Fighter B = new Fighter();


                Console.WriteLine("Fighter A: " + A.AssignName() + " Health:" + A.GetHp() + " \n Fighter B: " + B.AssignName() + " Health: " + B.GetHp());
                while (true)
                {
                    if (B.IsAlive())
                    {
                        int attack_A = A.Attack();
                        Console.WriteLine("Fighter A swing at fighter B dealing " + attack_A + " dmg ");

                        B.Hurt(attack_A);
                        Console.WriteLine("Figher B Health: " + B.GetHp());
                        Console.Read();
                    }
                    else
                    {
                        break;
                    }
                    if (A.IsAlive())
                    {
                        int attack_B = B.Attack();

                        Console.WriteLine("Fighter " + B.PresentName() + " swing at fighter" + A.PresentName() + " dealing " + attack_B + " dmg ");
                        A.Hurt(attack_B);

                        Console.WriteLine("Figher A Health: " + A.GetHp());
                        Console.ReadKey();
                    }
                    else
                    {
                        break;
                    }


                }
                if (A.IsAlive())
                {
                    Console.WriteLine("Grattis A");
                }
                else
                {
                    Console.WriteLine("Grattis B");
                }
                
                Console.ReadKey();
               // Console.Clear();

            }
            
        }
    }
}
