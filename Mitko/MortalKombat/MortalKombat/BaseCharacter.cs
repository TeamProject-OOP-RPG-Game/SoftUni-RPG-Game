namespace MortalKombat
{
    using System;
    using MortalKombat.Interfaces;

    public abstract class BaseCharacter : ICharacter, ISkills
    {
        private string name;
        private string description;
        private int health;
        private int speed;
        private int defense;
        private int criticalChance;
        
        public BaseCharacter(string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance)
        {
            this.Name = initialName;
            this.Description = description;
            this.Health = initialHealth;
            this.Speed = initialSpeed;
            this.Defense = initialDefense;
            this.CriticalChance = initialCriticalChance;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("BaseCharacter name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("BaseCharacter description cannot be null or empty!");
                }

                this.description = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter health cannot be negative!");
                }

                this.health = value;
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter speed cannot be negative!");
                }

                this.speed = value;
            }
        }

        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter defense cannot be negative!");
                }

                this.defense = value;
            }
        }

        public int CriticalChance
        {
            get
            {
                return this.criticalChance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter critical chance cannot be negative!");
                }

                this.criticalChance = value;
            }
        }
    }
}
