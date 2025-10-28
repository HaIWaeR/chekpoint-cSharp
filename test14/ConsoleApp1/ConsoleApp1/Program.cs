using ConsoleApp1.SpellMechanic;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spell fireball = new()
            {
                Name = "Fireball",
                Description = "Запускает в противника огненный шар",
                SpellParms = new Dictionary<int, SpellLevelPeremeter>()
                {
                    {
                        1,
                        new()
                        {
                            Damage = 100,
                            Cooldown = 3,
                            Manacast = 100,
                        }
                    },
                    {
                        2,
                        new()
                        {
                            Damage = 150,
                            Cooldown = 3,
                            Manacast = 90,
                        }
                    },
                    {
                        3,
                        new()
                        {
                            Damage = 200,
                            Cooldown = 2,
                            Manacast = 80,
                        }
                    }
                },
                SpellType = SpellTypeEnum.Damage,
                Mechanic = new SimpleProjectileMechanic1().Mechanic,
            };

            Spell splashHolyWater = new()
            {
                Name = "A splash of holy water",
                Description = "Машет бутылкой святой водой",
                SpellParms = new Dictionary<int, SpellLevelPeremeter>()
                {
                    {
                        1,
                        new()
                        {
                            Damage = 150,
                            Cooldown = 8,
                            Manacast = 0,
                        }
                    },
                    {
                        2,
                        new()
                        {
                            Damage = 150,
                            Cooldown = 4,
                            Manacast = 0,
                        }
                    },
                },
                SpellType = SpellTypeEnum.Damage,

                Mechanic = (caster, level, spell, target) =>
                {
                    if (!target.Tags.Contains(CharacterTagEnum.Demon))
                    {
                        Console.WriteLine("Заклинание нельзя наложить на цель кроме типа Demon");
                        return false;
                    }
                        
                    if (target.CurrentHealthPoints <= 0)
                    {
                        Console.WriteLine("Заклинание нельзя наложить на мертвую цель.");
                        return false;
                    }

                    int damage = spell.SpellParms[level].Damage;
                    Random rn = new Random();
                    int chance = rn.Next(0, 100);

                    if (chance <= 10)
                    {
                        Console.WriteLine("Вы пролили воду!");

                        if (caster.Tags.Contains(CharacterTagEnum.Demon))
                        {
                            Console.WriteLine($"Святая вода обжигает демона {caster.Name}!");
                            caster.GetHit(40);
                        }
                    }

                    else
                    {
                        target.GetHit(damage);
                    }
                    return true;
                }
            };

            Character hero = new Character("Ронал Варвар", 250, 300, 1, [CharacterTagEnum.Hero], 40, 40);
            Character ghoul = new Character("Нечесть", 150, 100, 1, [CharacterTagEnum.Humamoid], 20, 30);
            Character demon = new Character("Асмодей", 1000, 0, 10, [CharacterTagEnum.Demon], 70, 50);

            hero.LearnSpell(1, fireball); 

            hero.CastSpell("Fireball", ghoul);
            hero.CastSpell("Fireball", ghoul);
            hero.CastSpell("Fireball", ghoul);



        }
    }
}










