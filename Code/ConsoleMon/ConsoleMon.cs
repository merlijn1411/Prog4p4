using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        internal Element weakness;

        internal void  TakeDamage(int Damage)
        {
            this.health = health - Damage;
        }
        
        internal void DepleteEnergy(int Energy)
        {
            this.energy = energy - Energy;
        }


    }
}
