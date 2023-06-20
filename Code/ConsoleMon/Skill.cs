using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleMon
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        internal Element element;


        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
            if (target.weakness == element)
            {
                target.TakeDamage(damage / 2);
            }
        }
        public Skill() 
        {
            
        }

        internal Skill(int damage, int energyCost, string name, Element element) 
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
            
        }

        
    }
}
