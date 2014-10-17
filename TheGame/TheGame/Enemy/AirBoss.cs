using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class AirBoss:Boss, IBossDeffence, IBossAttack
    {
        private const string DefaultAirBossImagePath = "..//..//images/player.png";

        public AirBoss()
            : this(DefaultAirBossImagePath)
		{
		}

        public AirBoss(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
