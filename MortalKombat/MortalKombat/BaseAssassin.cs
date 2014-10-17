namespace MortalKombat
{
    using MortalKombat.Interfaces;
    public abstract class BaseAssassin : BaseCharacter, IAssassin
    {
        public BaseAssassin(string name, string description, int initialHealth, int initialSpeed, int initialDefense) 
            : base(name, description, initialHealth, initialSpeed, initialDefense)
        {
            this.RageMode = false;
        }

        public bool RageMode { get; set; }

        public void ToggleRageMode()
        {
            if (this.RageMode)
            {            
                this.Speed -= 50;
                this.Defense += 50;
            }
            else
            {
                this.Speed += 50;
                this.Defense -= 50;
            }

            this.RageMode = !this.RageMode;
        }
    }
}
