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
        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public bool IsAlive()
        {
            return hp > 0;  //If metod Onödig, bättre emd " return hp > 0; 
               
        }
        public int GetHp()
        {
            return hp;
        }

        public void SetHp(int h_p)
        {
            hp = h_p;
        }

    }
}
