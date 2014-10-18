namespace MortalKombat
{
    using System;
    using MortalKombat.Interfaces;
    public class BaseSkill
    {
        private string skillName;
        private string skillDescription;
        private int hitChance;
        private int damageMin;
        private int damageMax;

        public BaseSkill(string skillName, string skillDescription, int hitChance, int damageMin, int damageMax)
        {
            
        }

        public string SkillName
        {
            get
            {
                return this.skillName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Skill's name cannot be null or empty!");
                }

                this.skillName = value;
            }
        }

        public string SkillDescription
        {
            get
            {
                return this.skillDescription;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Skill's description cannot be null or empty!");
                }

                this.skillDescription = value;
            }
        }

        public int HitChance
        {
            get
            {
                return this.hitChance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Skill's hit chance cannot be negative!");
                }

                this.hitChance = value;
            }
        }

        public int DamageMin
        {
            get
            {
                return this.damageMin;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Skill's minimum damage cannot be negative!");
                }

                this.damageMin = value;
            }
        }

        public int DamageMax
        {
            get
            {
                return this.damageMax;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Skill's maximum damage cannot be negative!");
                }

                this.damageMax = value;
            }
        }
        public void UseSkill(ICharacter Enemy)
        {
            Enemy.Health -= 60;
        }
    }
}
