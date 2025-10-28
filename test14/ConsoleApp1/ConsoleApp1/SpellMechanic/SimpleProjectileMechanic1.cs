using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SpellMechanic
{
    public class SimpleProjectileMechanic1 : ISpellMechanic
    {
        public bool Mechanic(Character caster, int level, Spell spell, Character target)
        {
            if (target.Tags.Contains(CharacterTagEnum.Hero))
            {
                Console.WriteLine("Снаряд нельзя выпустить в цель типа Hero");
                return false;
            }

            if (target.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("Снаряд нельзя выпустить в мертвую цель.");
                return false;
            }

            int damage = spell.SpellParms[level].Damage;
            Random rn = new Random();
            int chance = rn.Next(0, 100);

            if (chance >= 90)
            {
                Console.WriteLine("Снаряд не попапл по цели");
            }
            else
            {
                target.GetHit(damage);
            }
            return true;
        }
    }
}
