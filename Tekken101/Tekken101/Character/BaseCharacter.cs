

namespace Tekken101.Characters
{
    using System;
    using Tekken101;
    using Interfaces;

    public abstract class BaseCharacter : GameObject, ICharacter, ICaster
    {
        private const int InitialSizeX = 160;
        private const int InitialSizeY = 350;
        private const int InitialY = 150;

        private string name;
        private string description;
        private int health;
        private int speed;
        private int defense;
        private int criticalChance;
        private int maxHealthPoints;
        
        public BaseCharacter(int X, string initialName, string description, int initialHealth, int initialSpeed, int initialDefense, int initialCriticalChance)
            :base (X, InitialY, InitialSizeX, InitialSizeY)
        {
            this.Name = initialName;
            this.Description = description;
            this.CurrentHealthPoints = initialHealth;
            this.Speed = initialSpeed;
            this.Defense = initialDefense;
            this.CriticalChance = initialCriticalChance;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int SizeX { get; set; }

        public int SizeY { get; set; }

        public int MaxHealthPoints
        {
            get
            {
                return this.maxHealthPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BaseCharacter max health cannot be negative!");
                }

                this.maxHealthPoints = value;
            }
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

        public int CurrentHealthPoints
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

        public abstract void CastSkillOne(ICharacter Enemy);

        public abstract void CastSkillTwo(ICharacter Enemy);

        public abstract void CastSkillThree(ICharacter Enemy);

        public abstract void CastSkillFour(ICharacter Enemy);

        
    }
}
