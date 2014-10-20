namespace MortalKombat
{
    using System;
    using MortalKombat.Interfaces;
    public abstract class BaseAssassin : BaseCharacter, IAssassin
    {

        private int lifeSteal;

        public BaseAssassin(string name, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialLifeSteal) 
            : base(name, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance)
        {
            this.LifeSteal = initialLifeSteal;
            this.RageMode = false;
        }

        public int LifeSteal
        {
            get
            {
                return this.lifeSteal;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Assassin's lifesteal cannot be negative!");
                }

                this.lifeSteal = value;
            }
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
