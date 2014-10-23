namespace Tekken101.Interfaces
{
    public interface ICaster
    {
        bool CastSkillOne(ICharacter Enemy);

        void CastSkillTwo(ICharacter Enemy);

        void CastSkillThree(ICharacter Enemy);

        void CastSkillFour(ICharacter Enemy);
    }
}
