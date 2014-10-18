namespace MortalKombat.Characters
{
    using MortalKombat.Interfaces;

    public class Alien : BaseAssassin
    {
        public const string DestriptionOne = "Bites the enemy and infect him with a poison: /n55% hit chance /n50-70 damage";
        public Alien(string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {

        }

        public override void CastSkillOne(ICharacter Enemy)
        {
            BaseSkill AttackOne = new BaseSkill("Dead Bite", DestriptionOne, 55, 50, 70);
            AttackOne.UseSkill(Enemy);
        }
    }
}
