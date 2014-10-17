using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    public class MagicSkills : BaseSkill
    {
        
        public int FireMagic(int damage,int hitChance, int criticalChance )
        {
            double healthDecrease;
            Random random = new Random();
                int randomHealt;

            if (BaseCharacter == BaseAssassin)
            {
                if (hitChance < 60)
                {
                    if (criticalChance > 0 && criticalChance < 20)
                    {
                        
                        randomHealt = random.Next(0, 20);
                        healthDecrease -= randomHealt;
                    }
                    else if (criticalChance > 21 && criticalChance < 50)
                    {
                        randomHealt = random.Next(21, 50);
                        healthDecrease -= randomHealt;
                    }
                    else if(criticalChance > 51 && criticalChance < 70)
                    {
                        randomHealt = random.Next(51, 70);
                        healthDecrease -= randomHealt;
                    }
                    else if (criticalChance > 71 && criticalChance < 100)
                    {
                        randomHealt = random.Next(71, 100);
                        healthDecrease -= randomHealt;
                    }
                }
                 if (BaseCharacter == BaseBerserk)
             {
                if (hitChance < 40)
                {
                    if (criticalChance > 0 && criticalChance < 20)
                    {
                        
                        randomHealt = random.Next(0, 20);
                        if (randomHealt > 5)
	                        {
		                         healthDecrease -= randomHealt-5;
	                        }
                        else
                        {
                            healthDecrease -= randomHealt;
                        }
                        
                    }
                    else if (criticalChance > 21 && criticalChance < 50)
                    {
                        randomHealt = random.Next(21, 50);
                        if (randomHealt > 26)
	                        {
		                         healthDecrease -= randomHealt-5;
	                        }
                        else
                        {
                            healthDecrease -= randomHealt;
                        }
                    }
                    else if(criticalChance > 51 && criticalChance < 70)
                    {
                        randomHealt = random.Next(51, 70);
                       if (randomHealt > 26)
	                        {
		                         healthDecrease -= randomHealt-5;
	                        }
                        else
                        {
                            healthDecrease -= randomHealt;
                        }
                    }
                    else if (criticalChance > 71 && criticalChance < 100)
                    {
                        randomHealt = random.Next(71, 100);
                        if (randomHealt > 26)
	                        {
		                         healthDecrease -= randomHealt-5;
	                        }
                        else
                        {
                            healthDecrease -= randomHealt;
                        }
                    }
                }
                
               

            }

            return healthDecrease;

        }


    }
    }
