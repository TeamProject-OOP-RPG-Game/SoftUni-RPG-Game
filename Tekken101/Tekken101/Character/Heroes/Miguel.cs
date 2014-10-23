namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Miguel : BaseBerserk
    {
        private const string DestriptionSkillOne = "Baptises yo ass: /n80% hit chance /n20-30 damage";
        private const string DestriptionSkillTwo = "Punishes you for your sins: /n50% hit chance /n5-55 damage";
        private const string DestriptionSkillThree = "Fuck you up with holy light: /n10% hit chance /n80-90 damage";
        private const string DestriptionSkillFour = "Summons angels to ambush you in the back: /n60% hit chance /n20-70 damage /n takes 100 health points from the caster";

        private BaseSkill attackOne = new BaseSkill(SpriteType.BountyBeat, "Bounty Beat", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackTwo = new BaseSkill(SpriteType.Exciter, "Exciter", DestriptionSkillTwo, 55, 50, 70, 200);
        private BaseSkill attackThree = new BaseSkill(SpriteType.Bottleneck, "Bottleneck", DestriptionSkillThree, 55, 50, 70, 200);
        private BaseSkill attackFour = new BaseSkill(SpriteType.Pinnacle, "Pinnacle", DestriptionSkillFour, 55, 50, 70, 200);

        public Miguel(SpriteType type, int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialStunChance) 
            : base(X, initialName, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialStunChance)
        {
            SpriteType = type;
            this.PlayerType = PlayerType.Miguel;
        }

        public override bool CastSkillOne(ICharacter Enemy)
        {
            bool isHit = this.attackOne.UseSkill(this, Enemy);
            return isHit;
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
