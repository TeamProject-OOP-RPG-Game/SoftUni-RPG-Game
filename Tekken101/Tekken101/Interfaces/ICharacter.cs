namespace Tekken101.Interfaces
{
    using Tekken101.Interfaces;

    public interface ICharacter
    {
        int X { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }
        int Speed { get; set; }
        int Defense { get; set; }
        int CriticalChance { get; set; }
        void Move(int distance);
    }
}