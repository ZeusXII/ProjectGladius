using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class FighterB : Fighter // Denna klass är onödig och en kvarleva efter första itterationen av FightSim projektet 
    {
        public int Attack2()
        {
            int fighter_attack = Attack();
            int fighterb_attack = fighter_attack + 10;

            return fighterb_attack;
        }



    }
}
