namespace MortalKombat
{
    using MortalKombat.Interfaces;
    public abstract class BaseBerserk : BaseCharacter, IBerserk
    {
        public BaseBerserk(string initialName, string description, int initialHealth, int initialSpeed, int initialDefense) 
            : base(initialName, description, initialHealth, initialSpeed, initialDefense)
        {
            this.DefenseMode = false;
        }



        public bool DefenseMode { get; set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.Defense -= 50;
                this.Speed += 50;
            }
            else
            {
                this.Defense += 50;
                this.Speed -= 50;
            }

            this.DefenseMode = !this.DefenseMode;
        }
    }
}
