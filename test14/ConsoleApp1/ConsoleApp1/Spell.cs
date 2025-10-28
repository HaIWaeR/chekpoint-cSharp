namespace ConsoleApp1
{
    public class Spell
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SpellTypeEnum SpellType { get; set; }
        public Dictionary<int, SpellLevelPeremeter> SpellParms { get; set; }
        public Func<Character, int, Spell, Character, bool> Mechanic { get; set; }

    }
}
    