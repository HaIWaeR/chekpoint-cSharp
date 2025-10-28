using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SpellMechanic
{
    public interface ISpellMechanic
    {
        bool Mechanic(Character caster, int level, Spell spell, Character target);
    }
}
