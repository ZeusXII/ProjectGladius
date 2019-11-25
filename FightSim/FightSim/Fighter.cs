using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        private int hp;
        public string name;

        bool isBlocking = false;

        public Fighter()
        {
            hp = 100;
        }
        public string AssignName()
        {
            Console.Write("Write the name of the fighter: ");
            name = Console.ReadLine();
            
 

            return name;
        }

        public string PresentName()
        {
            
            return name;
        }

        public int Attack()
        {
            var random = new Random();
            int randomNumber = random.Next(0, 10);
            return randomNumber;
        }
        public void Block()
        {
            isBlocking = true;
            
        }

        public void Hurt(int amount)
        {
            if (isBlocking)
            {
                hp -= amount / 2;
                isBlocking = false;
            }
            else
            {
                hp -= amount;
            }

            
        }

        public bool IsAlive()
        {
            return hp > 0;  //If metod onödig, bättre med return hp > 0; 

        }
        public int GetHp()
        {
            return hp;
        }

        public void TakeTurn(Fighter enemy) //block funktion kan skrivas/implementeras in i denna metod 
        {

            if (enemy.IsAlive())
            {
                int attack = Attack();
                Console.WriteLine("######################################\n######################################");
                Console.WriteLine(name + "'s turn\n Choose action 1.Attack 2.Block");// Undersök vad första kämpen har valt, 
                int battlechoice = int.Parse(Console.ReadLine());
                if (battlechoice == 1)
                {
                    enemy.Hurt(attack);

                    //om b har valt block  eller inte  om b har valt block do halvera attacken annars attackera med normal dmg
                    Console.WriteLine("-------------------------------------\n" + name +"'s turn action order\n" + name + " swing at " + enemy.name + " dealing: " + attack + " dmg");
                    //Console.WriteLine( name + " attackerade " + enemy.name);
                }
                else if(battlechoice == 2)
                {
                    Block();
                    Console.WriteLine("######################################\n " + name + "enters blocking stance " + enemy.name + " attack will not be as strong");

                }
                
                //Console.WriteLine(enemy.name + " Health: " + enemy.GetHp() + "\n######################################");
                //Console.Read();
           
            }


        }
        
    }
}
