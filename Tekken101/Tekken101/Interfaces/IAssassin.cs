namespace Tekken101.Interfaces
{
    public interface IAssassin
    {
        int LifeSteal { get; set; }
        bool RageMode { get; set; }
        void ToggleRageMode();
    }
}
