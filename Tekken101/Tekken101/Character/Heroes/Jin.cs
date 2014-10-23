namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Jin : BaseBerserk
    {
        public const string DestriptionSkillOne = "Baptises yo ass: /n80% hit chance /n20-30 damage";
        public const string DestriptionSkillTwo = "Punishes you for your sins: /n50% hit chance /n5-55 damage";
        public const string DestriptionSkillThree = "Fuck you up with holy light: /n10% hit chance /n80-90 damage";
        public const string DestriptionSkillFour = "Summons angels to ambush you in the back: /n60% hit chance /n20-70 damage /n takes 100 health points from the caster";

        private BaseSkill attackOne = new BaseSkill(SpriteType.CorpseThrust, "Corpse Thrust", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackTwo = new BaseSkill(SpriteType.FaceKick, "Face Kick", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackThree = new BaseSkill(SpriteType.EvilRoundhouse, "Evil Roundhouse", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackFour = new BaseSkill(SpriteType.TwinThrusts, "Twin Thrusts", DestriptionSkillOne, 55, 50, 70, 200);

        public Jin(SpriteType type, int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialStunChance)
            : base(X, initialName, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialStunChance)
        {
            SpriteType = type;
            this.PlayerType = PlayerType.Jin;
        }

        public override bool CastSkillOne(ICharacter Enemy)
        {
            bool isHit = this.attackOne.UseSkill(this, Enemy);
            return isHit;
        }

        public override bool CastSkillTwo(ICharacter Enemy)
        {
            bool isHit = this.attackOne.UseSkill(this, Enemy);
            return isHit;
        }

        public override bool CastSkillThree(ICharacter Enemy)
        {
            bool isHit = this.attackOne.UseSkill(this, Enemy);
            return isHit;
        }

        public override bool CastSkillFour(ICharacter Enemy)
        {
            bool isHit = this.attackOne.UseSkill(this, Enemy);
            return isHit;
        }
    }
}
