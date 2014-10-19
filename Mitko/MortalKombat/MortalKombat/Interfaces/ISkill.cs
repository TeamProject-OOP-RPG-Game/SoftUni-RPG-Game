﻿namespace MortalKombat.Interfaces
{
    public interface ISkill
    {
        string SkillName { get; set; }

        string SkillDescription { get; set; }

        int HitChance { get; set; }

        int DamageMin { get; set; }

        int DamageMax { get; set; }
        void UseSkill(ICharacter Caster, ICharacter Enemy);
    }
}
