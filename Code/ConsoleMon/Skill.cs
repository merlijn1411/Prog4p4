using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        internal int damage;
        internal int enegryCost;
        internal string name;


        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(caster);
            target.TakeDamage(target);
            
        }
    }
}
