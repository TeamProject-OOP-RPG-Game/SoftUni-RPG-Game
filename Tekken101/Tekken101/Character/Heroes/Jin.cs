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

        private BaseSkill attackOne;
        private BaseSkill attackTwo;
        private BaseSkill attackThree;
        private BaseSkill attackFour;

        public Jin(SpriteType type, int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialStunChance)
            : base(X, initialName, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialStunChance)
        {
            SpriteType = type;
            this.PlayerType = PlayerType.Jin;
        }
        public BaseSkill AttackOne
        {
            get
            {
                return this.attackOne;
            }

            set
            {
                this.attackOne = new BaseSkill(SpriteType.CorpseThrust, "Corpse Thrust", DestriptionSkillOne, 55, 50, 70, 200);
            }
        }

        public BaseSkill AttackTwo
        {
            get
            {
                return this.attackTwo;
            }

            set
            {
                this.attackTwo = new BaseSkill(SpriteType.FaceKick, "Face Kick", DestriptionSkillOne, 55, 50, 70, 200);
            }
        }

        public BaseSkill AttackThree
        {
            get
            {
                return this.attackThree;
            }

            set
            {
                this.attackThree = new BaseSkill(SpriteType.EvilRoundhouse, "Evil Roundhouse", DestriptionSkillOne, 55, 50, 70, 200);
            }
        }

        public BaseSkill AttackFour
        {
            get
            {
                return this.attackFour;
            }

            set
            {
                this.attackFour = new BaseSkill(SpriteType.TwinThrusts, "Twin Thrusts", DestriptionSkillOne, 55, 50, 70, 200);
            }
        }
        public override void CastSkillOne(ICharacter Enemy)
        {
            this.AttackOne.UseSkill(this, Enemy);
        }

        public override void CastSkillTwo(ICharacter Enemy)
        {
            this.AttackTwo.UseSkill(this, Enemy);
        }

        public override void CastSkillThree(ICharacter Enemy)
        {
            this.AttackThree.UseSkill(this, Enemy);
        }

        public override void CastSkillFour(ICharacter Enemy)
        {
            this.AttackFour.UseSkill(this, Enemy);
            this.CurrentHealth -= 20;
        }
    }
}
