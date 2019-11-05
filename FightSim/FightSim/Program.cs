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
            Fighter A = new Fighter();
            Fighter B = new Fighter();
            var random = new Random();
            int randomNumber = random.Next(100);
          
            //List<Fighter> Fighter = new List<Fighter>();
           
            
            A.SetHp(100);
            B.SetHp(100);
            Console.WriteLine("Fighter A: " + A.PresentName() + " Health:" + A.GetHp() + " \n Fighter B: " + B.PresentName() + " Health: " + B.GetHp());
            while(true){
                if(B.IsAlive()){
                    Console.WriteLine("Fighter A swing at fighter B dealing" + "dmg");
                    B.Hurt(randomNumber);
                    Console.WriteLine("Figher B Health: " + B.GetHp());
                }
                else{
                    break;
                }
                if(A.IsAlive()){
                    Console.WriteLine("Fighter B swing at fighter B dealing" + "dmg");
                    A.Hurt(randomNumber);
                    Console.WriteLine("Figher A Health: " + A.GetHp());
                }else{
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
        }
    }
}
