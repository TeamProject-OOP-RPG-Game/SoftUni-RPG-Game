namespace MortalKombat.Interfaces
{
    public interface IAssassin
    {
        int LifeSteal { get; set; }
        bool RageMode { get; set; }
        void ToggleRageMode();
    }
}
