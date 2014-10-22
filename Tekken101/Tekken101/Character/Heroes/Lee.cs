namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Lee : BaseAssassin
    {
        private const string DestriptionSkillOne = ": /n55% hit chance /n50-70 damage";
        private const string DestriptionSkillTwo = ": /n70% hit chance /n20-30 damage";
        private const string DestriptionSkillThree = ": /n10% hit chance /n80-90 damage";
        private const string DestriptionSkillFour = ": /n20% hit chance /n70-100 damage /n takes 20 health points from the caster";

        private BaseSkill attackOne = new BaseSkill(SpriteType.Bulldog, "Bulldog", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackTwo = new BaseSkill(SpriteType.Stunner, "Stunner", DestriptionSkillTwo, 55, 50, 70, 200);
        private BaseSkill attackThree = new BaseSkill(SpriteType.Stunner, "Stunner", DestriptionSkillTwo, 55, 50, 70, 200);
        private BaseSkill attackFour = new BaseSkill(SpriteType.Harassment, "Harassment", DestriptionSkillThree, 55, 50, 70, 200);

        public Lee(SpriteType type, int X, string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(X, name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {
            this.SpriteType = type;
            this.PlayerType = PlayerType.Lee;
        }

        public override void CastSkillOne(ICharacter Enemy)
        {
            this.attackOne.UseSkill(this, Enemy);
        }

        public override void CastSkillTwo(ICharacter Enemy)
        {
            this.attackTwo.UseSkill(this, Enemy);
        }

        public override void CastSkillThree(ICharacter Enemy)
        {
            this.attackThree.UseSkill(this, Enemy);
        }

        public override void CastSkillFour(ICharacter Enemy)
        {
            this.attackFour.UseSkill(this, Enemy);
            this.CurrentHealth -= 20;
        }
    }
}
