

namespace Tekken101.Characters
{
    using System;
    using Tekken101;
    using Interfaces;

    public abstract class BaseCharacter : GameObject, ICharacter, IMovable, ICaster
    {
        private const int InitialSizeX = 160;
        private const int InitialSizeY = 350;
        private const int InitialY = 150;
        private string name;
        private string description;
        private int currentHealth;
        private int maxHealth;
        private int speed;
        private int defense;
        private int criticalChance;
        private int maxHealthPoints;
        
        public BaseCharacter(int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance)
            :base (X, InitialY, InitialSizeX, InitialSizeY)
        {
            this.Name = initialName;
            this.Description = description;
            this.CurrentHealth = initialHealth;
            this.MaxHealth = initialHealth;
            this.Speed = initialSpeed;
            this.Defense = initialDefense;
            this.CriticalChance = initialCriticalChance;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int SizeX { get; set; }

        public int SizeY { get; set; }

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

        public int CurrentHealth
        {
            get
            {
                return this.currentHealth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter health cannot be negative!");
                }

                this.currentHealth = value;
            }
        }

        public int MaxHealth
        {
            get
            {
                return this.maxHealth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter health cannot be negative!");
                }

                this.maxHealth = value;
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

        public abstract void CastSkillOne(ICharacter Enemy);

        public abstract void CastSkillTwo(ICharacter Enemy);

        public abstract void CastSkillThree(ICharacter Enemy);

        public abstract void CastSkillFour(ICharacter Enemy);



        public void Move(int x)
        {
            this.X += x;
        }
    }
}
