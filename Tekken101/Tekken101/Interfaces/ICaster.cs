namespace Tekken101.Interfaces
{
    public interface ICaster
    {
        bool CastSkillOne(ICharacter Enemy);

        bool CastSkillTwo(ICharacter Enemy);

        bool CastSkillThree(ICharacter Enemy);

        bool CastSkillFour(ICharacter Enemy);
    }
}
