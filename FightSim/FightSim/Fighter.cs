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
        public string PresentName()
        {
           Console.Write("Write the name of the fighter: ");
           name = Console.ReadLine();
            return name;
        }
        
        public int Attack()
        {

            return 10;
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
