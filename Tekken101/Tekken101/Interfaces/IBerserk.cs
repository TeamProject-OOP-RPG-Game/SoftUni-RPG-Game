namespace Tekken101.Interfaces
{
    public interface IBerserk
    {
        int StunChance { get; set; }
        bool DefenseMode { get; set; }
        void ToggleDefenseMode();
    }
}
