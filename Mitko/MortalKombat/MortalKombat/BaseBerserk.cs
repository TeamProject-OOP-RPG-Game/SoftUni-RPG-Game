﻿namespace MortalKombat
{
    using System;
    using MortalKombat.Interfaces;
    public abstract class BaseBerserk : BaseCharacter, IBerserk
    {
        private int stunChance;
        public BaseBerserk(string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance, int initialStunChance) 
            : base(initialName, description, initialHealth, initialSpeed, initialDefense, initialCriticalChance)
        {
            this.DefenseMode = false;
        }


        public int StunChance
        {
            get
            {
                return this.stunChance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Berserk's stun chance cannot be negative!");
                }
            }
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