namespace Tekken101.Interfaces
{
    public interface ISkill
    {
        string SkillName { get; set; }

        string SkillDescription { get; set; }

        int HitChance { get; set; }

        int DamageMin { get; set; }

        int DamageMax { get; set; }

        bool UseSkill(ICharacter Caster, ICharacter Enemy);
    }
}
