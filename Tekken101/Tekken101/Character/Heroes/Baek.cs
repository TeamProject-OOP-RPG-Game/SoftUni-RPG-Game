namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;
  
    public class Baek : BaseAssassin
    {
        public const string DestriptionSkillOne = ": /n55% hit chance /n50-70 damage";
        public const string DestriptionSkillTwo = ": /n70% hit chance /n20-30 damage";
        public const string DestriptionSkillThree = ": /n10% hit chance /n80-90 damage";
        public const string DestriptionSkillFour = ": /n20% hit chance /n70-100 damage /n takes 20 health points from the caster";

        private BaseSkill attackOne = new BaseSkill(SpriteType.HammerHead, "Hammer Head", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackTwo = new BaseSkill(SpriteType.CobraBite, "Cobra Bite", DestriptionSkillTwo, 55, 50, 70, 200);
        private BaseSkill attackThree = new BaseSkill(SpriteType.HuntingSerpent, "Hunting Serpent", DestriptionSkillThree, 55, 50, 70, 200);
        private BaseSkill attackFour = new BaseSkill(SpriteType.SnakeRevenge, "Snake Revenge", DestriptionSkillFour, 55, 50, 70, 200);

        public Baek(SpriteType type, int X, string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(X, name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {
            this.SpriteType = type;
            this.PlayerType = PlayerType.Baek;
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
