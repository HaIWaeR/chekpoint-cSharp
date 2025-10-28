using System.Security.Authentication;

namespace ConsoleApp1
{
    public class Character
    {
        public string Name { get; private set; }
        public int MaxHealPoints { get; private set; }
        public int CurrentHealthPoints {  get; private set; }
        public int MaxManaPoints { get; private set; }
        public int MaxManaPoint { get; private set; }
        public int CurrentManaPoints { get; private set; }
        public int Level { get; private set; }
        public HashSet<CharacterTagEnum> Tags { get; private set; }
        public int BaseDamage { get; private set; }
        public int Armor { get; private set; }
        public Dictionary<string, LearnedSpell> SpellBook { get; private set; }

        public Character(string name, int healthPoints, int manaPoint, int level, HashSet<CharacterTagEnum> tags, int baseDamage, int armor)
        {
            Name = name;
            MaxHealPoints = healthPoints;
            CurrentHealthPoints = healthPoints;
            CurrentManaPoints = manaPoint;
            MaxManaPoint = manaPoint;
            Level = level;
            Tags = tags;
            BaseDamage = baseDamage;
            Armor = armor;
            SpellBook = new Dictionary<string, LearnedSpell>();
        }

        public void LearnSpell(int level, Spell spell)
        {
            if (Tags.Contains(CharacterTagEnum.Hero))
            {
                Console.WriteLine($"{Name} изучил заклинание {spell.Name} {level} уровня!");
            }
            SpellBook[spell.Name] = new LearnedSpell()
            {
                Level = level,
                Prototype = spell,
            };
        }

        public bool CastSpell(string spellName, Character target)
        {

            if (!SpellBook.ContainsKey(spellName))
            {
                Console.WriteLine($"{Name} не владеет заклинанием {spellName}");
                return false;
            }

            var learndSpell = SpellBook[spellName];
            var manacast = SpellBook[spellName].LevelParameter.Manacast;
            
            if (manacast > CurrentManaPoints)
            {
                Console.WriteLine($"{Name} не хватает маны на использование заклинания {spellName}");
                return false;
            }
            else
            {
                Console.WriteLine($"{Name} использует заклинание {spellName} на {target.Name}");
                bool spellUsed = learndSpell.Prototype.Mechanic(this, learndSpell.Level, learndSpell.Prototype, target);

                if (spellUsed)
                {
                    CurrentManaPoints -= manacast;
                    return true;
                }
                return false;
            }
        }

        public bool GetHeal(int heal)
        {
            CurrentHealthPoints = CurrentHealthPoints + heal > MaxHealPoints ? MaxHealPoints : 
                CurrentHealthPoints + heal;
            return CurrentHealthPoints == MaxHealPoints;
        }

        public bool GetHit(int damage)
        {
            int scale = (int)(Armor * 0.7);
            int finalDamage = damage - scale;

            CurrentHealthPoints -= finalDamage;
            Console.WriteLine($"{Name} получил {finalDamage} урона.");
            Console.WriteLine($"Броня снизилась изночальынй урон на {scale}");

            if (CurrentHealthPoints < 0)
            {
                Console.WriteLine($"{Name}");
                return true;
            }
            Console.WriteLine($" У {Name} осталось {CurrentHealthPoints} здоровья");
            return false;
        }
    }
}
