using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class WaterBoss:Boss, IBossAttack, IBossDeffence
    {
        private const string DefaultWaterBossImagePath = "..//..//images/player.png";

        public WaterBoss()
            : this(DefaultWaterBossImagePath)
		{
		}

        public WaterBoss(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
