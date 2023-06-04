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
        internal int health { get; set; }
        internal int energy { get; set; }
        internal string name { get; set; }

        internal Element weakness;

        public List<Skill> skills { get; set; }

        internal void  TakeDamage(int Damage)
        {
            this.health = health - Damage;
        }
        
        internal void DepleteEnergy(int Energy)
        {
            this.energy = energy - Energy;
        }
        public ConsoleMon()
        {

        }
        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
           
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;
            this.health = health;

        }


    }
}
