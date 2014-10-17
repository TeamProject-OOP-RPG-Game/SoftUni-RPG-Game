using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class EarthBoss:Boss, IBossDeffence, IBossAttack
    {
        private const string DefaultEarthBossImagePath = "..//..//images/player.png";

        public EarthBoss()
            : this(DefaultEarthBossImagePath)
		{
		}

        public EarthBoss(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
