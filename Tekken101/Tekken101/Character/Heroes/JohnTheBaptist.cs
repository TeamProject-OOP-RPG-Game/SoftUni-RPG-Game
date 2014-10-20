namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class JohnTheBaptist : BaseBerserk
    {
        private const string DestriptionSkillOne = "Baptises yo ass: /n80% hit chance /n20-30 damage";
        private const string DestriptionSkillTwo = "Punishes you for your sins: /n50% hit chance /n5-55 damage";
        private const string DestriptionSkillThree = "Fuck you up with holy light: /n10% hit chance /n80-90 damage";
        private const string DestriptionSkillFour = "Summons angels to ambush you in the back: /n60% hit chance /n20-70 damage /n takes 100 health points from the caster";

        public JohnTheBaptist(SpriteType type, int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialStunChance) 
            : base(X, initialName, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialStunChance)
        {
            SpriteType = type;
        }

        public override void CastSkillOne(ICharacter Enemy)
        {
            BaseSkill AttackOne = new BaseSkill("Baptism", DestriptionSkillOne, 80, 20, 30);
            AttackOne.UseSkill(this, Enemy);
        }

        public override void CastSkillTwo(ICharacter Enemy)
        {
            BaseSkill AttackTwo = new BaseSkill("Repentance", DestriptionSkillTwo, 50, 5, 55);
            AttackTwo.UseSkill(this, Enemy);
        }

        public override void CastSkillThree(ICharacter Enemy)
        {
            BaseSkill AttackThree = new BaseSkill("Holy Light", DestriptionSkillThree, 10, 80, 90);
            AttackThree.UseSkill(this, Enemy);
        }

        public override void CastSkillFour(ICharacter Enemy)
        {
            BaseSkill AttackFour = new BaseSkill("Divine Ambush", DestriptionSkillFour, 60, 20, 70);
            AttackFour.UseSkill(this, Enemy);
            this.CurrentHealthPoints -= 100;
        }
    }
}
