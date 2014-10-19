namespace MortalKombat.Interfaces
{
    public interface ICaster
    {
        void CastSkillOne(ICharacter Enemy);

        void CastSkillTwo(ICharacter Enemy);

        void CastSkillThree(ICharacter Enemy);

        void CastSkillFour(ICharacter Enemy);
    }
}
