namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Leo : BaseAssassin
    {
        private const string DestriptionSkillOne = ": /n55% hit chance /n50-70 damage";
        private const string DestriptionSkillTwo = ": /n70% hit chance /n20-30 damage";
        private const string DestriptionSkillThree = ": /n10% hit chance /n80-90 damage";
        private const string DestriptionSkillFour = ": /n20% hit chance /n70-100 damage /n takes 20 health points from the caster";

        private BaseSkill attackOne;
        private BaseSkill attackTwo;
        private BaseSkill attackThree;
        private BaseSkill attackFour;

        public Leo(SpriteType type, int X, string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(X, name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {
            this.SpriteType = type;
            this.PlayerType = PlayerType.Leo;
        }
        public BaseSkill AttackOne
        {
            get
            {
                return this.attackOne;
            }

            set
            {
                this.attackOne = new BaseSkill(SpriteType.GutPalmer, "Gut Palmer", DestriptionSkillOne, 55, 50, 70, 200);
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
                this.attackTwo = new BaseSkill(SpriteType.TumbleDry, "Tumble Dry", DestriptionSkillTwo, 55, 50, 70, 200);
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
                this.attackThree = new BaseSkill(SpriteType.TwinLancers, "Twin Lancers", DestriptionSkillThree, 55, 50, 70, 200);
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
                this.attackFour = new BaseSkill(SpriteType.Chiropractor, "Chiropractor", DestriptionSkillFour, 55, 50, 70, 200);
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
