namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Nina : BaseAssassin
    {
        private const string DestriptionSkillOne = ": /n55% hit chance /n50-70 damage";
        private const string DestriptionSkillTwo = ": /n70% hit chance /n20-30 damage";
        private const string DestriptionSkillThree = ": /n10% hit chance /n80-90 damage";
        private const string DestriptionSkillFour = ": /n20% hit chance /n70-100 damage /n takes 20 health points from the caster";

        public Nina(SpriteType type, int X, string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(X, name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {
            this.SpriteType = type;
        }

        public override void CastSkillOne(ICharacter Enemy)
        {
            BaseSkill AttackOne = new BaseSkill("Dead Bite", DestriptionSkillOne, 55, 50, 70);
            AttackOne.UseSkill(this, Enemy);
        }

        public override void CastSkillTwo(ICharacter Enemy)
        {
            BaseSkill AttackTwo = new BaseSkill("Rat Attack", DestriptionSkillTwo, 55, 50, 70);
            AttackTwo.UseSkill(this, Enemy);
        }

        public override void CastSkillThree(ICharacter Enemy)
        {
            BaseSkill AttackThree = new BaseSkill("Rat Attack", DestriptionSkillThree, 55, 50, 70);
            AttackThree.UseSkill(this, Enemy);
        }

        public override void CastSkillFour(ICharacter Enemy)
        {
            BaseSkill AttackFour = new BaseSkill("Virus Injection", DestriptionSkillFour, 20, 70, 100);
            AttackFour.UseSkill(this, Enemy);
            this.CurrentHealth -= 20;
        }
    }
}
