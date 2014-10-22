

namespace Tekken101.Characters
{
    using System;
    using Interfaces;
    using Renderer;
    public class BaseSkill : ISkill
    {
        private string skillName;
        private string skillDescription;
        private int hitChance;
        private int damageMin;
        private int damageMax;
        private int range;

        public BaseSkill(SpriteType spriteType, string skillName, string skillDescription, int hitChance, int damageMin, int damageMax, int range)
        {
            this.SpriteType = spriteType;
            this.SkillName = skillName;
            this.SkillDescription = skillDescription;
            this.HitChance = hitChance;
            this.DamageMin = damageMin;
            this.DamageMax = damageMax;
            this.Range = range;

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

        public int Range
        {
            get
            {
                return this.range;
            }

            set
            {
                this.range = value;
            }
        }

        public SpriteType SpriteType { get; set; }

        public void UseSkill(ICharacter Caster, ICharacter Enemy)
        {
            Enemy.CurrentHealth -= 60;
        }
    }
}
