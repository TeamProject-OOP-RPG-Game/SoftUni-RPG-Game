namespace MortalKombat.Interfaces
{
    public interface ICharacter
    {
        string Name { get; set; }
        string Description { get; set; }
        int Health { get; set; }
        int Speed { get; set; }
        int Defense { get; set; }
        int CriticalChance { get; set; }
    }
}