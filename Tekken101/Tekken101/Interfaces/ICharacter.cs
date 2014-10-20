namespace Tekken101.Interfaces
{
    using Tekken101.Interfaces;

    public interface ICharacter
    {
        string Name { get; set; }
        string Description { get; set; }
        int CurrentHealthPoints { get; set; }
        int MaxHealthPoints { get; set; }
        int Speed { get; set; }
        int Defense { get; set; }
        int CriticalChance { get; set; }
    }
}