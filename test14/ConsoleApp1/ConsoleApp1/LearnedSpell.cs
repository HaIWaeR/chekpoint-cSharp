namespace ConsoleApp1
{
    public class LearnedSpell
    {
        public int Level { get; set; }
        public Spell Prototype { get; set; }
        public SpellLevelPeremeter LevelParameter => Prototype.SpellParms[Level];
    }
}
