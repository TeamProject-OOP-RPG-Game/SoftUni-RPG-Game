﻿namespace Tekken101.Characters
{
    using Interfaces;
    using Tekken101.Renderer;

    public class Christie : BaseAssassin
    {
        public const string DestriptionSkillOne = ": /n55% hit chance /n50-70 damage";
        public const string DestriptionSkillTwo = ": /n70% hit chance /n20-30 damage";
        public const string DestriptionSkillThree = ": /n10% hit chance /n80-90 damage";
        public const string DestriptionSkillFour = ": /n20% hit chance /n70-100 damage /n takes 20 health points from the caster";

        private BaseSkill attackOne = new BaseSkill(SpriteType.FreakShow, "Freak Show", DestriptionSkillOne, 55, 50, 70, 200);
        private BaseSkill attackTwo = new BaseSkill(SpriteType.SatelliteMoon, "Satellite Moon", DestriptionSkillTwo, 55, 50, 70, 200);
        private BaseSkill attackThree = new BaseSkill(SpriteType.Samba, "Samba", DestriptionSkillThree, 55, 50, 70, 200);
        private BaseSkill attackFour = new BaseSkill(SpriteType.AirMail, "Air Mail", DestriptionSkillFour, 55, 50, 70, 200);

        public Christie(SpriteType type, int X, string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal)
            : base(X, name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance, initialLifeSteal)
        {
            this.SpriteType = type;
            this.PlayerType = PlayerType.Christie;
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
