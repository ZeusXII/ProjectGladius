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

        public Fighter() //Konstruktor för klassen fighter
        {
            hp = 100;
        }
        public string AssignName() //MEtod för att namnge slagkämarna
        {
            Console.Write("Write the name of the fighter: ");
            name = Console.ReadLine();
            
 

            return name;
        }

        public string PresentName() //metod för att presentera/printa ut namnet på slagkämarna
        {
            
            return name;
        }

        public int Attack() //Metod för attacken salgkämpen utdelar 
        {
            var random = new Random();
            int randomNumber = random.Next(0, 10);
            return randomNumber;
        }
        public void Block() //Metod som gör att slagkämpen blockerar 50% av inkommande attack 
        {
            isBlocking = true;
            
        }

        public void Hurt(int amount) //Metod som avgör hur mcyket skda slagkämpen mottar
        {
            if (isBlocking) //If sats om avgör om slagkämpen blockerar eller inte
            {
                hp -= amount / 2;
                isBlocking = false;
            }
            else
            {
                hp -= amount;
            }

            
        }

        public bool IsAlive() //Kollar om slagkämpen är vid liv
        {
            return hp > 0;  //If metod onödig, bättre med return hp > 0; 

        }
        public int GetHp() //Retunerar vad slagkämpen har för HP
        {
            return hp;
        }

        public void TakeTurn(Fighter enemy) //Metod som utgör logiken i striden, slagkämpe A's tur, följt av att slagkämpe B's tur
        {                                  

            if (enemy.IsAlive()) //Fortsätter striden om slagkämpen lever  
            {
                int attack = Attack(); //Attack
                Console.WriteLine("######################################\n######################################");
                Console.WriteLine(name + "'s turn\n Choose action 1.Attack 2.Block");// Undersök vad första kämpen har valt, 
                int battlechoice = int.Parse(Console.ReadLine());
                if (battlechoice == 1) //Metod som kollar om motståndaren blockerar inkommande attack eller om attacken blir normal
                {
                    enemy.Hurt(attack);

                    //om b har valt block  eller inte  om b har valt block do halvera attacken annars attackera med normal dmg
                    Console.WriteLine("-------------------------------------\n" + name +"'s action order\n" + name + " swing at " + enemy.name + " dealing: " + attack + " dmg");
                    //Console.WriteLine( name + " attackerade " + enemy.name);
                }
                else if(battlechoice == 2) 
                {
                    Block();
                    Console.WriteLine("######################################\n " + name + " enters blocking stance " + enemy.name + " attack will not be as strong");

                }
                
                Console.WriteLine(enemy.name + " Health: " + enemy.GetHp() + "\n######################################");
                //Console.Read();
           
            }


        }
        
    }
}
